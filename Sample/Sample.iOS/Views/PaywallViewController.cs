using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;
using Sample.Core.ViewModels;

namespace Sample.iOS.Views;

/// <summary>
/// Presented modally by MvvmCross via [MvxModalPresentation].
/// Embeds RCPaywallViewController as a child view controller so the
/// native RevenueCat paywall UI fills the screen.
/// </summary>
[MvxModalPresentation(WrapInNavigationController = false)]
public class PaywallViewController : MvxViewController<PaywallViewModel>
{
    public override void ViewDidLoad()
    {
        base.ViewDidLoad();
        View!.BackgroundColor = UIColor.SystemBackground;

        var paywall = new RevenueCatUI.RCPaywallViewController(
            offering: null,
            displayCloseButton: true,
            shouldBlockTouchEvents: false,
            dismissRequestedHandler: _ =>
            {
                DismissViewController(animated: true, completionHandler: () =>
                    ViewModel?.CloseCommand.Execute(null));
            });

        AddChildViewController(paywall);
        paywall.View!.Frame = View!.Bounds;
        paywall.View!.AutoresizingMask =
            UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleHeight;
        View!.AddSubview(paywall.View!);
        paywall.DidMoveToParentViewController(this);
    }
}
