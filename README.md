# RevenueCat .NET Bindings

Unofficial .NET bindings for the [RevenueCat](https://www.revenuecat.com/) SDKs, for **.NET iOS** and **.NET Android**.

> This package is **not affiliated with RevenueCat**.

## Packages

| Package | Platform | Wraps | Current version |
|---|---|---|---|
| [RevenueCat.DotNet.Bindings](https://www.nuget.org/packages/RevenueCat.DotNet.Bindings) | .NET iOS | [purchases-ios](https://github.com/RevenueCat/purchases-ios) | 5.84.0 |
| [RevenueCatUI.DotNet.Bindings](https://www.nuget.org/packages/RevenueCatUI.DotNet.Bindings) | .NET iOS | purchases-ios (UI) | 5.84.0 |
| [RevenueCat.DotNet.Android.Bindings](https://www.nuget.org/packages/RevenueCat.DotNet.Android.Bindings) | .NET Android | [purchases-android](https://github.com/RevenueCat/purchases-android) | 10.17.0 |
| [RevenueCatUI.DotNet.Android.Bindings](https://www.nuget.org/packages/RevenueCatUI.DotNet.Android.Bindings) | .NET Android | purchases-android (UI) | 10.17.0 |

The binding package version tracks the underlying native RevenueCat SDK version.

## Configure

**iOS**
```csharp
RevenueCat.RCPurchases.ConfigureWithAPIKey("appl_your_api_key");
```

**Android**
```csharp
Com.Revenuecat.Purchases.Purchases.Configure(
    new Com.Revenuecat.Purchases.PurchasesConfiguration.Builder(this, "goog_your_api_key")
        .Build());
```

Enable verbose SDK logging while developing:

```csharp
RevenueCat.RCPurchases.LogLevel = RevenueCat.RCLogLevel.Debug;          // iOS
Com.Revenuecat.Purchases.Purchases.LogLevel = LogLevel.Debug;          // Android
```

## iOS Test Store API-Key does not work for me, what should I do?

If you are using a **TestStore** key, use the latest `-rc1` NuGet version.

Reason:
- The `-rc1` packages use a RevenueCat **Debug** build. RevenueCat prevents the TestStore key from working in a **Release** build.
- When you're done with the TestStore key, replace it with your production API key and switch to the latest stable (non-`rc1`) NuGet version, which uses the RevenueCat Release build.

## Sample app

A small MvvmCross sample for both platforms lives in [`Sample/`](Sample):

- `Sample.Core` — shared view models / services
- `Sample.iOS` / `Sample.Android` — platform heads

**Provide your API key** in [`Sample/Sample.Core/KeyConstants.cs`](Sample/Sample.Core/KeyConstants.cs):

```csharp
public const string RevenueCatApiKey = ""; // ← put your platform key here (appl_… for iOS, goog_… for Android)
```

> ⚠️ The key is intentionally empty in source control — never commit a real API key. Use a platform-specific key (`appl_…` for the iOS head, `goog_…` for the Android head).

The sample resolves the bindings from local `bin/Debug` packages (see `Sample/nuget.config`), so build the binding projects first if you change them.
