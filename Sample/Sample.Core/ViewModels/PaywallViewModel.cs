using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace Sample.Core.ViewModels;

public class PaywallViewModel : MvxViewModel
{
    private readonly IMvxNavigationService _navigationService;

    public IMvxAsyncCommand CloseCommand { get; }

    public PaywallViewModel(IMvxNavigationService navigationService)
    {
        _navigationService = navigationService;
        CloseCommand = new MvxAsyncCommand(() => _navigationService.Close(this));
    }
}
