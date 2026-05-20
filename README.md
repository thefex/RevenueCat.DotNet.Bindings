nuget package: 
https://www.nuget.org/packages/RevenueCat.DotNet.Bindings
https://www.nuget.org/packages/RevenueCatUI.DotNet.Bindings/

https://www.nuget.org/packages/RevenueCat.DotNet.Android.Bindings
https://www.nuget.org/packages/RevenueCatUI.DotNet.Android.Bindings

.NET-iOS + .NET-Android

# iOS Test Store API-Key does not work for me, what should I do?
If you are using the TestStore key use latest version -rc1 nuget.

Reason:
- it uses RevenueCat Debug build, RevenueCat prevents TestStore key from working in Release build.
- when you're done with TestStore key, replace it with prod API Key, switch to latest stable version of the nuget package, which uses RevenueCat Release build
