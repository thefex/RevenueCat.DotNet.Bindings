nuget package: 
https://www.nuget.org/packages/RevenueCat.DotNet.Bindings

.NET-iOS only as for now. 
Maybe in future for Android, if i ever need it.

# Test Store API-Key does not work for me, what should I do?
If you are using the TestStore key use latest version -rc1 nuget.

Reason:
- it uses RevenueCat Debug build, RevenueCat prevents TestStore key from working in Release build.
- when you're done with TestStore key, replace it with prod API Key, switch to latest stable version of the nuget package, which uses RevenueCat Release build