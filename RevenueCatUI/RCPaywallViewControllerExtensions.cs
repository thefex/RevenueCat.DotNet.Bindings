namespace RevenueCatUI;

public static class RCPaywallViewControllerExtensions
{
    public static void SetDelegate(this RCPaywallViewController paywallViewController, IRCPaywallViewControllerDelegate del)
    {
        paywallViewController.WeakDelegate = del as NSObject;
    }
}