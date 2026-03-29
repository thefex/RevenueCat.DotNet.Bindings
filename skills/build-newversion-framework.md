# Build New Version of RevenueCat Frameworks and .NET Bindings

Follow these steps whenever a new version of RevenueCat is released and you need to update the xcframeworks and regenerate the .NET iOS bindings.

---

## Prerequisites

- Xcode installed
- CocoaPods installed (`sudo gem install cocoapods`)
- Objective Sharpie installed (`sharpie` available in PATH)
- .NET SDK with iOS workload installed (`dotnet workload install ios`)

---

## Step 1 — Prepare a temporary Xcode workspace

Create a temporary working directory outside the repo, then set up a minimal Xcode project with CocoaPods.

```bash
mkdir -p ~/tmp/rcbuild && cd ~/tmp/rcbuild
```

Create a blank Xcode project named `revenuecatbindings` (single-view iOS app target), then add a `Podfile` in the same folder:

```ruby
platform :ios, '16.0'
use_frameworks!

target 'revenuecatbindings' do
  pod 'RevenueCat'
  pod 'RevenueCatUI'
end
```

Install pods:

```bash
pod install
```

---

## Step 2 — Build Debug configuration (device + simulator)

```bash
# Device — Debug
xcodebuild \
  -workspace revenuecatbindings.xcworkspace \
  -scheme revenuecatbindings \
  -configuration Debug \
  -sdk iphoneos \
  -derivedDataPath temporary-debug \
  ONLY_ACTIVE_ARCH=NO \
  BUILD_LIBRARY_FOR_DISTRIBUTION=YES \
  build

# Simulator — Debug
xcodebuild \
  -workspace revenuecatbindings.xcworkspace \
  -scheme revenuecatbindings \
  -configuration Debug \
  -sdk iphonesimulator \
  -derivedDataPath temporary-debug-sim \
  ONLY_ACTIVE_ARCH=NO \
  BUILD_LIBRARY_FOR_DISTRIBUTION=YES \
  build
```

---

## Step 3 — Build Release configuration (device + simulator)

```bash
# Device — Release
xcodebuild \
  -workspace revenuecatbindings.xcworkspace \
  -scheme revenuecatbindings \
  -configuration Release \
  -sdk iphoneos \
  -derivedDataPath temporary-release \
  ONLY_ACTIVE_ARCH=NO \
  BUILD_LIBRARY_FOR_DISTRIBUTION=YES \
  build

# Simulator — Release
xcodebuild \
  -workspace revenuecatbindings.xcworkspace \
  -scheme revenuecatbindings \
  -configuration Release \
  -sdk iphonesimulator \
  -derivedDataPath temporary-release-sim \
  ONLY_ACTIVE_ARCH=NO \
  BUILD_LIBRARY_FOR_DISTRIBUTION=YES \
  build
```

---

## Step 4 — Create xcframeworks

Do this for both `RevenueCat` and `RevenueCatUI`. Repeat the pattern below, replacing `RevenueCat` with `RevenueCatUI` where needed.

### RevenueCat — Debug xcframework

```bash
xcodebuild -create-xcframework \
  -framework temporary-debug/Build/Products/Debug-iphoneos/RevenueCat.framework \
  -framework temporary-debug-sim/Build/Products/Debug-iphonesimulator/RevenueCat.framework \
  -output RevenueCat-debug.xcframework
```

### RevenueCat — Release xcframework

```bash
xcodebuild -create-xcframework \
  -framework temporary-release/Build/Products/Release-iphoneos/RevenueCat.framework \
  -framework temporary-release-sim/Build/Products/Release-iphonesimulator/RevenueCat.framework \
  -output RevenueCat.xcframework
```

### RevenueCatUI — Debug xcframework

```bash
xcodebuild -create-xcframework \
  -framework temporary-debug/Build/Products/Debug-iphoneos/RevenueCatUI.framework \
  -framework temporary-debug-sim/Build/Products/Debug-iphonesimulator/RevenueCatUI.framework \
  -output RevenueCatUI-debug.xcframework
```

### RevenueCatUI — Release xcframework

```bash
xcodebuild -create-xcframework \
  -framework temporary-release/Build/Products/Release-iphoneos/RevenueCatUI.framework \
  -framework temporary-release-sim/Build/Products/Release-iphonesimulator/RevenueCatUI.framework \
  -output RevenueCatUI.xcframework
```

---

## Step 5 — Copy xcframeworks into the binding projects

Replace the existing xcframeworks in the repo:

```bash
REPO=<path-to-repo-root>

# RevenueCat
rm -rf $REPO/RevenueCat/RevenueCat-debug.xcframework
rm -rf $REPO/RevenueCat/RevenueCat.xcframework
cp -R RevenueCat-debug.xcframework $REPO/RevenueCat/
cp -R RevenueCat.xcframework $REPO/RevenueCat/

# RevenueCatUI
rm -rf $REPO/RevenueCatUI/RevenueCatUI-debug.xcframework
rm -rf $REPO/RevenueCatUI/RevenueCatUI.xcframework
cp -R RevenueCatUI-debug.xcframework $REPO/RevenueCatUI/
cp -R RevenueCatUI.xcframework $REPO/RevenueCatUI/
```

---

## Step 6 — Regenerate API definitions with Objective Sharpie

Run sharpie against the **Release device** headers. Check the available iOS SDK version with `sharpie xcode -sdks` first.

### 6a — Generate into a temp folder

```bash
sharpie bind \
  -output RevenueCat-bindings-new \
  -namespace RevenueCat \
  -sdk iphoneos \
  temporary-release/Build/Products/Release-iphoneos/RevenueCat.framework/Headers/RevenueCat-Swift.h

sharpie bind \
  -output RevenueCatUI-bindings-new \
  -namespace RevenueCatUI \
  -sdk iphoneos \
  temporary-release/Build/Products/Release-iphoneos/RevenueCatUI.framework/Headers/RevenueCatUI-Swift.h
```

### 6b — Diff against the previous generated files

The `generated/` folder in the repo contains the sharpie output from the **previous** release. Diff the freshly generated files against it to understand exactly what changed:

```bash
diff $REPO/generated/RevenueCat/ApiDefinitions.cs  RevenueCat-bindings-new/ApiDefinitions.cs
diff $REPO/generated/RevenueCat/StructsAndEnums.cs RevenueCat-bindings-new/StructsAndEnums.cs

diff $REPO/generated/RevenueCatUI/ApiDefinitions.cs RevenueCatUI-bindings-new/ApiDefinitions.cs
```

Look for:
- **New types / methods** — must be added to the binding `ApiDefinitions.cs` / `ApiDefinition.cs`
- **Removed types / methods** — must be removed from the binding files
- **New enum cases or structs** — must be added to `StructsAndEnums.cs`
- **`[Verify]` attributes** on any new items — review and resolve each one before building

### 6c — Merge changes into the binding project files

Apply the diff results manually (or with your editor's merge tool) into the actual binding files in the repo:

```
RevenueCat/ApiDefinitions.cs      ← merge new/changed API definitions
RevenueCat/StructsAndEnums.cs     ← merge new/changed enums and structs

RevenueCatUI/ApiDefinition.cs     ← merge new/changed API definitions
RevenueCatUI/StructsAndEnums.cs   ← merge new/changed enums and structs
```

> **Do not blindly overwrite** the binding files with the raw sharpie output — the binding files may contain manual fixes and hand-written extensions (e.g. `RCPaywallViewControllerExtensions.cs`) that sharpie does not know about.

### 6d — Update the `generated/` snapshot

Once the merge is done, update the `generated/` folder so it reflects the current release for future diffs:

```bash
cp RevenueCat-bindings-new/ApiDefinitions.cs  $REPO/generated/RevenueCat/ApiDefinitions.cs
cp RevenueCat-bindings-new/StructsAndEnums.cs $REPO/generated/RevenueCat/StructsAndEnums.cs
cp RevenueCatUI-bindings-new/ApiDefinitions.cs $REPO/generated/RevenueCatUI/ApiDefinitions.cs
```

---

## Step 7 — Merge split Swift extension interfaces

Objective Sharpie generates a separate `interface` block for every Swift `extension` on a type, giving them auto-generated names like `RevenueCat_Swift_3187`, `RevenueCat_Swift_4021`, etc. Merge all of these into the **primary interface for that type** so the SDK surface is clean and unified.

### 7a — Identify extension interfaces to merge

Look for any `[BaseType (typeof (SomeType))]` interface whose name contains `_Swift_NNNN`. Group them by the base type they extend:

```csharp
// These three all extend RCPurchases
[BaseType (typeof (RCPurchases))]
interface RCPurchases_RevenueCat_Swift_3187 { ... }

[BaseType (typeof (RCPurchases))]
interface RCPurchases_RevenueCat_Swift_4021 { ... }

[BaseType (typeof (RCPurchases))]
interface RCPurchases_RevenueCat_Swift_5902 { ... }
```

If any of them carry `[Category]`, **remove it** — it causes bgen to generate an incompatible static class when instance members or properties are present.

### 7b — Move members into the primary interface

Find the existing primary `interface RCPurchases { ... }` declaration and append all members from the `_Swift_NNNN` blocks directly into it:

```csharp
// Primary interface — extension members folded in
[TV (15, 0), Mac (12, 0), iOS (15, 0)]
[BaseType (typeof (NSObject))]
interface RCPurchases {
    // ... original members ...

    // --- from RCPurchases_RevenueCat_Swift_3187 ---
    [Export ("someMethod")]
    void SomeMethod ();

    // --- from RCPurchases_RevenueCat_Swift_4021 ---
    [Export ("anotherMethod")]
    void AnotherMethod ();

    // --- from RCPurchases_RevenueCat_Swift_5902 ---
    [Export ("thirdMethod")]
    void ThirdMethod ();
}
```

> If no primary interface exists for the base type (rare — only happens for types that are entirely defined via Swift extensions), create one with the correct `[BaseType]` and move everything there.

### 7c — Delete the individual split interfaces

Remove all the original `_Swift_NNNN` interface blocks from the file once their members have been moved.

### 7d — Ensure a single `[BaseType]` attribute per interface

After merging, each interface must have **exactly one** `[BaseType(...)]` attribute. bgen will produce duplicate member errors if two `[BaseType]` lines appear on the same interface. Remove any orphaned `[BaseType]` lines that get left behind when extension blocks are deleted.

### 7e — Remove `partial interface Constants` blocks that import native symbols

Sharpie generates `partial interface Constants` blocks for C-level symbols (version number fields, `__Internal` library imports). These are **not needed** in the .NET binding surface and will cause build errors (`[Field]` on a `byte[]`). Remove any `partial interface Constants` block whose body references `__Internal`:

```csharp
// REMOVE THIS BLOCK
[Static]
partial interface Constants {
    // extern double RevenueCatVersionNumber;
    [Field ("RevenueCatVersionNumber", "__Internal")]
    double RevenueCatVersionNumber { get; }

    // extern NSString * _Nonnull RevenueCatVersionString;
    [Field ("RevenueCatVersionString", "__Internal")]
    NSString RevenueCatVersionString { get; }
}
```

Use a brace-stack parser (not regex) to find the block boundaries reliably, since inner `{ get; }` bodies contain `}` characters.

### 7f — Fix nested `Action<Action<...>>` delegates

Sharpie generates `Action<Action<T1, T2, T3, T4>>` for ObjC blocks-within-blocks (e.g. the "start purchase" callback). bgen cannot generate trampolines for nested generic delegates. Fix by defining custom delegates and replacing the nested Action:

```csharp
// At the top of the namespace, define:
delegate void RCPurchaseCompletionBlock (RCStoreTransaction transaction, RCCustomerInfo info, NSError error, bool userCancelled);
delegate void RCStartPurchaseBlock (RCPurchaseCompletionBlock purchaseBlock);

// Then replace every occurrence of:
//   Action<Action<RCStoreTransaction, RCCustomerInfo, NSError, bool>>
// with:
//   RCStartPurchaseBlock
```

Place delegate declarations **inside** the namespace block (not at file scope), otherwise bgen generates `global::` references without a namespace that result in `CS1001: Identifier expected`.

### 7g — Fix duplicate C# method signatures from merged extensions

Extensions from different `_Swift_NNNN` blocks may bring in methods with the same C# name and parameter types (e.g. `logIn:completion:` and `logIn:completionHandler:` both map to `void LogIn(string, Action<...>)`). Rename the second occurrence to avoid `CS0111`:

```csharp
// First occurrence (keep as-is)
[Export ("logIn:completion:")]
void LogIn (string appUserID, Action<RCCustomerInfo, bool, NSError> completion);

// Second occurrence — rename to make unique
[Export ("logIn:completionHandler:")]
void LogInWithCompletionHandler (string appUserID, Action<RCCustomerInfo, bool, NSError> completionHandler);
```

### Rules of thumb

| Situation | Action |
|---|---|
| `_Swift_NNNN` interfaces for a type that has a primary interface | Move members into that primary interface |
| `_Swift_NNNN` interfaces for a type with **no** primary interface | Create `interface X { }` and move all members there |
| A `_Swift_NNNN` interface has `[Category]` | Remove `[Category]` before merging |
| A `_Swift_NNNN` interface has `: ISomeProtocol` conformance and `[Category]` | Drop the protocol conformance too (a static Category class can't implement interfaces) |
| Multiple `_Swift_NNNN` blocks extend the same type | Only one `[BaseType]` on the final merged interface |
| `partial interface Constants` with `__Internal` fields | Remove the entire block (not needed in SDK surface) |
| Nested `Action<Action<T1,T2,...>>` | Define custom delegate + replace (see 7f above) |
| Two merged methods have the same C# signature | Rename the second one (see 7g above) |

---

## Step 8 — Update version numbers in csproj files

Update the `<Version>` (Release) and the Debug `<Version>` (with `-rc1` suffix) in both:

- `RevenueCat/RevenueCat.csproj`
- `RevenueCatUI/RevenueCatUI.csproj`

Example for version `5.59.0`:

```xml
<Version>5.59.0</Version>           <!-- in the main PropertyGroup -->
...
<Version>5.59.0-rc1</Version>       <!-- in the Debug-only PropertyGroup -->
```

---

## Step 9 — Build the .NET binding projects

```bash
cd $REPO

# Build Release NuGet packages
dotnet build RevenueCat/RevenueCat.csproj -c Release
dotnet build RevenueCatUI/RevenueCatUI.csproj -c Release

# Optionally build Debug packages (rc1)
dotnet build RevenueCat/RevenueCat.csproj -c Debug
dotnet build RevenueCatUI/RevenueCatUI.csproj -c Debug
```

NuGet packages will be output to `RevenueCat/bin/Release/` and `RevenueCatUI/bin/Release/`.

---

## Cleanup

Remove the temporary build directory when done:

```bash
rm -rf ~/tmp/rcbuild
```
