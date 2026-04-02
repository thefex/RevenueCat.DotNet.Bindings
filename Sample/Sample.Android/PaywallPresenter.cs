using MvvmCross.IoC;
using MvvmCross.Platforms.Android;
using MvvmCross.Platforms.Android.Presenters;
using MvvmCross.Platforms.Android.Views;
using MvvmCross.ViewModels;
using Sample.Android.Views;
using Sample.Core.ViewModels;

namespace Sample.Android;

/// <summary>
/// Custom presenter that intercepts navigation to <see cref="PaywallViewModel"/> and instead
/// calls <see cref="MainView.LaunchPaywall"/> on the current top Activity, using RevenueCat's
/// <c>PaywallActivityLauncher</c>. This keeps the paywall launch tied to the Activity Result API
/// registered in <see cref="MainView.OnCreate"/> without MvvmCross managing a separate view.
/// All other navigation is handled by the default MvvmCross Android presenter.
/// </summary>
public class PaywallPresenter : MvxAndroidViewPresenter
{
    public PaywallPresenter(IEnumerable<System.Reflection.Assembly> androidViewAssemblies)
        : base(androidViewAssemblies) { }

    public override async Task<bool> Show(MvxViewModelRequest request)
    {
        if (request.ViewModelType == typeof(PaywallViewModel))
        {
            var topActivity = MvxIoCProvider.Instance
                ?.Resolve<IMvxAndroidCurrentTopActivity>()?.Activity;
            if (topActivity is MainView mainView)
            {
                mainView.LaunchPaywall();
                return true;
            }
        }

        return await base.Show(request);
    }
}
