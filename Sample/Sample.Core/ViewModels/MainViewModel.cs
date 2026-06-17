using Microsoft.Extensions.Logging;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using Sample.Core.Services;

namespace Sample.Core.ViewModels;

public class MainViewModel : MvxViewModel
{
    private readonly IRevenueCatService _revenueCatService;
    private readonly IMvxNavigationService _navigationService;
    private readonly ILogger<MainViewModel> _logger;

    private bool _isPremium;
    public bool IsPremium
    {
        get => _isPremium;
        set
        {
            SetProperty(ref _isPremium, value);
            RaisePropertyChanged(() => StatusText);
        }
    }

    private bool _isBusy;
    public bool IsBusy
    {
        get => _isBusy;
        set => SetProperty(ref _isBusy, value);
    }

    public string StatusText => IsPremium ? "⭐ Premium" : "🔒 Free";

    public IMvxAsyncCommand CheckStatusCommand { get; }
    public IMvxAsyncCommand ShowPaywallCommand { get; }

    public MainViewModel(
        IRevenueCatService revenueCatService,
        IMvxNavigationService navigationService,
        ILogger<MainViewModel> logger)
    {
        _revenueCatService = revenueCatService;
        _navigationService = navigationService;
        _logger = logger;

        CheckStatusCommand = new MvxAsyncCommand(CheckPremiumStatusAsync);
        ShowPaywallCommand = new MvxAsyncCommand(ShowPaywallAsync);
    }

    public override Task Initialize()
    {
        _logger.LogInformation("MainViewModel initializing");
        // Don't await the network call here — awaiting blocks MvvmCross from
        // presenting the view until customer info returns (and if the API key is
        // missing/invalid the callback may never fire, leaving a blank screen).
        // Fire it off and let IsPremium update reactively when it completes.
        _ = CheckPremiumStatusAsync();
        return Task.CompletedTask;
    }

    private Task ShowPaywallAsync()
    {
        _logger.LogInformation("Navigating to paywall");
        return _navigationService.Navigate<PaywallViewModel>();
    }

    private async Task CheckPremiumStatusAsync()
    {
        IsBusy = true;
        try
        {
            _logger.LogInformation("Checking premium status…");
            IsPremium = await _revenueCatService.IsPremiumAsync();
            _logger.LogInformation("Premium status resolved: {Status}", StatusText);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to check premium status");
        }
        finally
        {
            IsBusy = false;
        }
    }
}
