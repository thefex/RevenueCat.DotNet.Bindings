# Build New Version of RevenueCat .NET Android Bindings

Follow these steps whenever a new version of RevenueCat is released and you need to update the .NET Android bindings.

---

## Prerequisites

- .NET SDK with Android workload installed (`dotnet workload install android`)
- Android SDK installed (via Android Studio or command-line tools)

---

## Step 1 — Find the new version on Maven Central

Look up the latest version of both artifacts on Maven Central:

- **purchases** → https://central.sonatype.com/artifact/com.revenuecat.purchases/purchases
- **purchases-ui** → https://central.sonatype.com/artifact/com.revenuecat.purchases/purchases-ui

Note the version string (e.g. `9.28.1`). Both artifacts are always released together at the same version.

---

## Step 2 — Update the version in the binding project files

Update `<Version>` and `AndroidMavenLibrary Version=` in both `.csproj` files. Also update the AAR filename in `RevenueCatUI.Android/libs/`.

```bash
# Download the new purchases-ui AAR into libs/
cd RevenueCatUI.Android/libs
curl -O "https://repo1.maven.org/maven2/com/revenuecat/purchases/purchases-ui/NEW_VERSION/purchases-ui-NEW_VERSION.aar"
rm purchases-ui-OLD_VERSION.aar
```

Update `RevenueCatUI.Android.csproj`:
```xml
<AndroidLibrary Include="libs/purchases-ui-NEW_VERSION.aar" Bind="true" />
```

---

## Step 3 — Resolve Java dependency errors (RevenueCat.Android only)

`RevenueCat.Android` uses `AndroidMavenLibrary` so the dep verifier runs. `RevenueCatUI.Android` uses a direct AAR reference — the verifier does **not** run, so no dep entries are needed there.

### Rule: prefer MS-maintained NuGet packages over AndroidMavenLibrary

Before adding `<AndroidMavenLibrary Bind="false" />` or `<AndroidIgnoredJavaDependency />` for a dependency, **check if Microsoft maintains a NuGet package for it**:

> 📋 **Full list**: https://github.com/dotnet/android-libraries/blob/main/config.json

If a NuGet exists, add a `<PackageReference>` instead. This gives proper dependency resolution and avoids duplicate AAR conflicts.

#### NuGet ID patterns

| Java groupId prefix | NuGet prefix | Example |
|---|---|---|
| `androidx.*` | `Xamarin.AndroidX.*` | `Xamarin.AndroidX.Lifecycle.Runtime` |
| `com.android.billingclient:*` | `Xamarin.Android.Google.BillingClient` | — |
| `com.google.android.gms:play-services-*` | `Xamarin.GooglePlayServices.*` | `Xamarin.GooglePlayServices.Ads.Identifier` |
| `org.jetbrains.kotlin:*` | `Xamarin.Kotlin.*` | `Xamarin.Kotlin.StdLib` |
| `org.jetbrains.kotlinx:*` | `Xamarin.KotlinX.*` | `Xamarin.KotlinX.Coroutines.Core`, `Xamarin.KotlinX.Serialization.Json` |
| `org.jetbrains:annotations` | `Xamarin.Jetbrains.Annotations` | — |
| `com.google.crypto.tink:tink-android` | `Xamarin.Google.Crypto.Tink.Android` | — |
| `com.google.android.datatransport:*` | `Xamarin.Google.Android.DataTransport.*` | `TransportApi`, `TransportBackendCct`, `TransportRuntime` |
| `com.google.code.gson:gson` | `GoogleGson` | — |

#### NuGet version format

NuGet versions do **not** always match Maven versions directly:

- **AndroidX**: usually adds a 4th digit — Maven `2.5.0` → NuGet `2.5.0` or `2.5.0.N`
- **play-services**: adds 100 to the major — Maven `17.0.1` → NuGet `117.0.1.N`
- **Kotlin/KotlinX**: usually same version with optional `.N` suffix

Always verify the exact NuGet version at https://nuget.org or via:
```bash
curl -s "https://api.nuget.org/v3-flatcontainer/xamarin.androidx.lifecycle.runtime/index.json" \
  | python3 -c "import json,sys; v=json.load(sys.stdin)['versions']; print([x for x in v if x.startswith('2.5.0')])"
```

#### Important: NuGet transitive version graph

When you add a NuGet package, its own dependencies may require **newer versions** of other packages than RevenueCat's POM specifies. For example, `Xamarin.Android.Google.BillingClient 8.0.0` transitively pulls `Xamarin.AndroidX.Activity 1.12.4.1` which requires lifecycle `2.10.0.2`, coroutines `1.10.2.3`, etc.

**You must use the version the NuGet graph dictates — not the Maven version.**
The Maven dep verifier only checks `>=`, so a newer NuGet version always satisfies an older Maven requirement.

The dep verifier requires **explicit** `<PackageReference>` entries — transitively included packages do not count.

#### For deps without a matching NuGet

Use `<AndroidMavenLibrary Bind="false" />` for direct deps:
```xml
<AndroidMavenLibrary Include="dev.drewhamilton.poko:poko-annotations" Version="0.17.2" Bind="false" />
<AndroidMavenLibrary Include="com.google.crypto.tink:tink-android" Version="1.8.0" Bind="false" />
```

Use `<AndroidIgnoredJavaDependency />` only for deep transitive deps that have no NuGet at all:
```xml
<AndroidIgnoredJavaDependency Include="com.google.android.datatransport:transport-api:3.0.0" />
<AndroidIgnoredJavaDependency Include="com.google.code.gson:gson:2.8.9" />
```

> **Format**: must be `groupId:artifactId:version` (all three parts). Only one entry per `groupId:artifactId` key — duplicates cause XAJDV7004.

---

## Step 4 — purchases-ui: AndroidMavenLibrary with AndroidIgnoredJavaDependency

`purchases-ui` uses `AndroidMavenLibrary`. Its POM declares `purchases` as a `compile` dependency and many Compose/AndroidX libs as `runtime` dependencies — the dep verifier checks all of them.


```xml
<AndroidMavenLibrary Include="com.revenuecat.purchases:purchases-ui" Version="9.28.1" />
<!-- purchases satisfied by ProjectReference -->
<AndroidIgnoredJavaDependency Include="com.revenuecat.purchases:purchases:9.28.1" />
<!-- Kotlin — transitively satisfied via ProjectReference -->
<AndroidIgnoredJavaDependency Include="org.jetbrains.kotlin:kotlin-parcelize-runtime:2.0.21" />
<AndroidIgnoredJavaDependency Include="org.jetbrains.kotlinx:kotlinx-serialization-json:1.5.1" />
<!-- All Compose, lifecycle-ktx, fragment-ktx, browser, window, coil, commonmark, etc. -->
<AndroidIgnoredJavaDependency Include="androidx.compose.ui:ui:1.7.5" />
<!-- ... one entry per dep reported by the verifier ... -->
```

`AndroidIgnoredJavaDependency` format is always `groupId:artifactId:version` (all three parts required). When upgrading RevenueCat, re-run the build and add any new verifier errors as additional `AndroidIgnoredJavaDependency` entries.

---

## Step 5 — Fix C# binding errors with Metadata transforms

Even after dependencies are resolved, the binding tooling may emit C# compile errors. Fix these in `Transforms/Metadata.xml`.

### Common errors and fixes

#### IParcelableCreator return type mismatch (CS0738)
`Creator<T>.createFromParcel` returns `T`, but `IParcelableCreator` requires `Object`:
```xml
<attr path="/api/package[@name='com.example']/class[@name='Foo.Creator']/method[@name='createFromParcel']" name="managedReturn">Java.Lang.Object</attr>
<attr path="/api/package[@name='com.example']/class[@name='Foo.Creator']/method[@name='newArray']" name="managedReturn">Java.Lang.Object[]</attr>
```

#### KotlinX Serializer interface mismatch (CS0738 / CS0535)
`IKSerializer<T>` covariance — `deserialize` returns `T`, `serialize` takes `T`:
```xml
<attr path="/api/package[@name='com.example']/class[@name='Foo.Serializer']/method[@name='deserialize']" name="managedReturn">Java.Lang.Object</attr>
<attr path="/api/package[@name='com.example']/class[@name='Foo.Serializer']/method[@name='serialize' and count(parameter)=2]/parameter[2]" name="type">java.lang.Object</attr>
```

#### ActivityResultContract abstract method mismatch (CS0534)
Newer AndroidX Activity NuGet changed abstract method signatures to use `Object`. If the bound class has covariant overrides that don't match, the simplest fix is to remove the class (it's an internal Android contract, not useful from C#):
```xml
<remove-node path="/api/package[@name='com.example']/class[@name='ShowSomething']" />
```

#### Interface implements conflict (CS0535 / enum collision)
If a Java class implements an interface that conflicts with a C# enum or another type:
```xml
<attr path="/api/package[@name='com.example']/class[@name='FooMode']" name="implements" />
```

#### Return type covariance (CS0738)
When a subclass returns a more specific type than the interface requires:
```xml
<attr path="/api/package[@name='com.example']/class[@name='Foo']/method[@name='getBar']" name="managedReturn">Com.Example.IBar</attr>
```

#### Remove unimplementable methods
```xml
<remove-node path="/api/package[@name='com.example']/class[@name='Foo']/method[@name='problematic']" />
```

---

## Step 6 — Build both projects

```bash
cd <repo-root>
dotnet build RevenueCat.Android/RevenueCat.Android.csproj -c Release
dotnet build RevenueCatUI.Android/RevenueCatUI.Android.csproj -c Release
```

NuGet packages are output to `bin/Release/`.

---

## Rules of thumb

| Situation | Action |
|---|---|
| Dep has MS NuGet in config.json | Use `<PackageReference>` — never `AndroidMavenLibrary Bind="false"` |
| NuGet version conflicts (NU1605 downgrade) | Use the version the NuGet graph requires, not the Maven version |
| Dep verifier still fails after adding NuGet | NuGet must be **explicit** in csproj — transitive doesn't satisfy the verifier |
| No MS NuGet for the dep | `<AndroidMavenLibrary Bind="false" />` for direct deps |
| No MS NuGet, deep transitive | `<AndroidIgnoredJavaDependency Include="g:a:v" />` |
| purchases-ui dep verifier errors | `AndroidIgnoredJavaDependency` — runtime Compose/UI deps don't need PackageReference in binding project |
| `purchases` dep in purchases-ui POM | `AndroidIgnoredJavaDependency Include="com.revenuecat.purchases:purchases:X.Y.Z"` — satisfied by ProjectReference |
| CS0738 Creator/Serializer return type | Fix `managedReturn` in Metadata.xml |
| CS0534 ActivityResultContract mismatch | `<remove-node>` the class — it's not useful from C# |
| XAJDV7004 duplicate key | Only one `AndroidIgnoredJavaDependency` per `groupId:artifactId` |
