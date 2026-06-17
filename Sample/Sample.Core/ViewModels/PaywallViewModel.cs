using Microsoft.Extensions.Logging;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace Sample.Core.ViewModels;

public class PaywallViewModel : MvxViewModel
{
    private readonly IMvxNavigationService _navigationService;
    private readonly ILogger<PaywallViewModel> _logger;

    public IMvxAsyncCommand CloseCommand { get; }

    public PaywallViewModel(IMvxNavigationService navigationService, ILogger<PaywallViewModel> logger)
    {
        _navigationService = navigationService;
        _logger = logger;
        CloseCommand = new MvxAsyncCommand(CloseAsync);
    }

    public override Task Initialize()
    {
        _logger.LogInformation("Paywall opened");
        return base.Initialize();
    }

    private Task CloseAsync()
    {
        _logger.LogInformation("Paywall closed");
        return _navigationService.Close(this);
    }
}
