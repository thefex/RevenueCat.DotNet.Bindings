using Com.Revenuecat.Purchases;
using Com.Revenuecat.Purchases.Interfaces;
using Microsoft.Extensions.Logging;
using Sample.Core.Services;

namespace Sample.Android.Services;

public class RevenueCatService : IRevenueCatService
{
    private readonly ILogger<RevenueCatService> _logger;

    public RevenueCatService(ILogger<RevenueCatService> logger)
    {
        _logger = logger;
    }

    public Task<bool> IsPremiumAsync()
    {
        var tcs = new TaskCompletionSource<bool>();

        _logger.LogInformation("Fetching customer info to determine premium status…");
        Purchases.SharedInstance.GetCustomerInfo(new CustomerInfoCallback(
            onReceived: info =>
            {
                var activeCount = info.ActiveSubscriptions.Count;
                var isPremium = activeCount > 0;
                _logger.LogInformation(
                    "Customer info received. ActiveSubscriptions={Count}, IsPremium={IsPremium}",
                    activeCount, isPremium);
                tcs.TrySetResult(isPremium);
            },
            onError: error =>
            {
                _logger.LogError("Failed to fetch customer info: {Code} {Error}", error.Code, error.Message);
                tcs.TrySetResult(false);
            }));
        return tcs.Task;
    }

    private sealed class CustomerInfoCallback : Java.Lang.Object, IReceiveCustomerInfoCallback
    {
        private readonly Action<CustomerInfo> _onReceived;
        private readonly Action<PurchasesError> _onError;

        public CustomerInfoCallback(Action<CustomerInfo> onReceived, Action<PurchasesError> onError)
        {
            _onReceived = onReceived;
            _onError = onError;
        }

        public void OnReceived(CustomerInfo customerInfo) => _onReceived(customerInfo);
        public void OnError(PurchasesError error) => _onError(error);
    }
}
