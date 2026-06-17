using System.Diagnostics.CodeAnalysis;
using CoreSpotlight;
using MvvmCross.Platforms.Ios.Core;
using MvvmCross.Platforms.Ios.Views;
using RevenueCat;
using Sample.Core;

namespace Sample.iOS;

[Register("AppDelegate")]
public class AppDelegate : MvxSceneApplicationDelegate
{  
    public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
    {
        // Verbose RevenueCat SDK logging in debug builds (must be set before configuring).
#if DEBUG
        RevenueCat.RCPurchases.LogLevel = RevenueCat.RCLogLevel.Debug;
#endif

        // Configure RevenueCat — API key is set in KeyConstants
        RevenueCat.RCPurchases.ConfigureWithAPIKey(KeyConstants.RevenueCatApiKey);
        var result = base.FinishedLaunching(application, launchOptions);
        
        return result;
    }
}

[Register("AppSceneDelegate")]
[SuppressMessage("Interoperability", "CA1422:Validate platform compatibility")]
[SuppressMessage("Trimming", "IL2046:\'RequiresUnreferencedCodeAttribute\' annotations must match across all interface implementations or overrides.")]
public class AppSceneDelegate : MvxSceneDelegate<Setup, App>
{
        
#pragma warning disable IL2026
    public AppSceneDelegate()
    {
    }
#pragma warning restore IL2026
}