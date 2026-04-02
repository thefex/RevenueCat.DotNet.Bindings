using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;
using Sample.Core.ViewModels;

namespace Sample.iOS.Views;

[MvxRootPresentation(WrapInNavigationController = true)]
public class MainViewController : MvxViewController<MainViewModel>
{
    private UILabel _statusLabel = null!;
    private UIActivityIndicatorView _spinner = null!;
    private UIButton _checkButton = null!;
    private UIButton _paywallButton = null!;

    public override void ViewDidLoad()
    {
        base.ViewDidLoad();

        Title = "RevenueCat Sample";
        View!.BackgroundColor = UIColor.SystemBackground;

        _statusLabel = new UILabel
        {
            TextAlignment = UITextAlignment.Center,
            Font = UIFont.SystemFontOfSize(28, UIFontWeight.Bold),
            TranslatesAutoresizingMaskIntoConstraints = false
        };

        _spinner = new UIActivityIndicatorView(UIActivityIndicatorViewStyle.Medium)
        {
            HidesWhenStopped = true,
            TranslatesAutoresizingMaskIntoConstraints = false
        };

        _checkButton = UIButton.FromType(UIButtonType.System);
        _checkButton.SetTitle("Check Status", UIControlState.Normal);
        _checkButton.TranslatesAutoresizingMaskIntoConstraints = false;

        _paywallButton = UIButton.FromType(UIButtonType.System);
        _paywallButton.SetTitle("Show Paywall", UIControlState.Normal);
        _paywallButton.TranslatesAutoresizingMaskIntoConstraints = false;

        var stack = new UIStackView(new UIView[] { _statusLabel, _spinner, _checkButton, _paywallButton })
        {
            Axis = UILayoutConstraintAxis.Vertical,
            Spacing = 20,
            Alignment = UIStackViewAlignment.Center,
            TranslatesAutoresizingMaskIntoConstraints = false
        };

        View.AddSubview(stack);
        NSLayoutConstraint.ActivateConstraints(new[]
        {
            stack.CenterXAnchor.ConstraintEqualTo(View.CenterXAnchor),
            stack.CenterYAnchor.ConstraintEqualTo(View.CenterYAnchor),
            stack.LeadingAnchor.ConstraintEqualTo(View.LeadingAnchor, 32),
            stack.TrailingAnchor.ConstraintEqualTo(View.TrailingAnchor, -32)
        });

        var set = this.CreateBindingSet<MainViewController, MainViewModel>();
        set.Bind(_statusLabel).For(v => v.Text).To(vm => vm.StatusText);
        set.Bind(_spinner).For(v => v.Hidden).To(vm => vm.IsBusy).WithConversion("InvertedBool");
        set.Bind(_checkButton).To(vm => vm.CheckStatusCommand);
        set.Bind(_paywallButton).To(vm => vm.ShowPaywallCommand);
        set.Apply();
    }
}
