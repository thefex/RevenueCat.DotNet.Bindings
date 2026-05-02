using Android.Widget;
using AndroidX.Activity.Result;
using Com.Revenuecat.Purchases.UI.Revenuecatui.Activity;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views;
using MvvmCross.Plugin.Visibility;
using Sample.Core.ViewModels;
using Object = Java.Lang.Object;

namespace Sample.Android.Views;

/// <summary>
/// The single Activity in the sample. It owns a <see cref="PaywallActivityLauncher"/> registered
/// during OnCreate (required by AndroidX Activity Result API). When MvvmCross navigates to
/// <see cref="PaywallViewModel"/> the custom presenter calls <see cref="LaunchPaywall"/> instead
/// of starting a new Activity/Fragment managed by MvvmCross.
/// </summary>
[MvxActivityPresentation]
[Activity(Label = "RevenueCat Sample", MainLauncher = true, Theme = "@style/AppTheme")]
public class MainView : MvxActivity<MainViewModel>
{
    private PaywallActivityLauncher _paywallLauncher = null!;

    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        SetContentView(Resource.Layout.activity_main);

        // IPaywallResultHandler must be a separate Java.Lang.Object subclass due to Java generics
        // erasure — implementing it directly on MvxActivity causes a javac type-clash.
        var resultHandler = new PaywallResultCallback(() =>
            ViewModel?.CheckStatusCommand.Execute(null));

        // Must be registered in OnCreate — ActivityResultCaller requires this before onStart.
        _paywallLauncher = new PaywallActivityLauncher(this, resultHandler);

        var statusText = FindViewById<TextView>(Resource.Id.statusText)!;
        var checkButton = FindViewById<Button>(Resource.Id.checkButton)!;
        var paywallButton = FindViewById<Button>(Resource.Id.paywallButton)!;

        var set = this.CreateBindingSet<MainView, MainViewModel>();
        set.Bind(statusText).For(v => v.Text).To(vm => vm.StatusText);

        set.Bind(checkButton).To(vm => vm.CheckStatusCommand);
        set.Bind(paywallButton).To(vm => vm.ShowPaywallCommand);
        set.Apply();
    }

    /// <summary>Called by <see cref="PaywallPresenter"/> when navigating to <see cref="PaywallViewModel"/>.</summary>
    public void LaunchPaywall() => _paywallLauncher.Launch();
}

/// <summary>
/// Separate <see cref="Java.Lang.Object"/> subclass implementing <see cref="IPaywallResultHandler"/>.
/// Cannot be implemented directly on the Activity due to Java generics erasure constraints.
/// </summary>
internal sealed class PaywallResultCallback : Java.Lang.Object, IPaywallResultHandler
{
    private readonly Action _onResult;

    public PaywallResultCallback(Action onResult) => _onResult = onResult;


    public void OnActivityResult(PaywallResult? result)
    {
        _onResult();
    }
}
