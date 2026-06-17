using Android.Runtime;
using Microsoft.Extensions.Logging;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.Platforms.Android.Views;
using Sample.Core;

namespace Sample.Android;

[Application]
public class MainApplication : MvxAndroidApplication<Setup, App>
{
    public MainApplication(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer) { }

    public override void OnCreate()
    {
        base.OnCreate();

        // Verbose RevenueCat SDK logging in debug builds (must be set before configuring).
#if DEBUG
        Com.Revenuecat.Purchases.Purchases.LogLevel = Com.Revenuecat.Purchases.LogLevel.Debug!;
#endif

        Com.Revenuecat.Purchases.Purchases.Configure(
            new Com.Revenuecat.Purchases.PurchasesConfiguration.Builder(this, KeyConstants.RevenueCatApiKey)
                .Build());
    }
}
