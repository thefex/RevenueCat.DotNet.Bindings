using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using Sample.Core.Services;

namespace Sample.Core.ViewModels;

public class MainViewModel : MvxViewModel
{
    private readonly IRevenueCatService _revenueCatService;
    private readonly IMvxNavigationService _navigationService;

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

    public MainViewModel(IRevenueCatService revenueCatService, IMvxNavigationService navigationService)
    {
        _revenueCatService = revenueCatService;
        _navigationService = navigationService;

        CheckStatusCommand = new MvxAsyncCommand(CheckPremiumStatusAsync);
        ShowPaywallCommand = new MvxAsyncCommand(() => _navigationService.Navigate<PaywallViewModel>());
    }

    public override async Task Initialize()
    {
        await CheckPremiumStatusAsync();
    }

    private async Task CheckPremiumStatusAsync()
    {
        IsBusy = true;
        try
        {
            IsPremium = await _revenueCatService.IsPremiumAsync();
        }
        finally
        {
            IsBusy = false;
        }
    }
}
