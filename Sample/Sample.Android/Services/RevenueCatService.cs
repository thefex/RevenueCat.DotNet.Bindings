using Com.Revenuecat.Purchases;
using Com.Revenuecat.Purchases.Interfaces;
using Sample.Core.Services;

namespace Sample.Android.Services;

public class RevenueCatService : IRevenueCatService
{
    public Task<bool> IsPremiumAsync()
    {
        var tcs = new TaskCompletionSource<bool>();
        Purchases.SharedInstance.GetCustomerInfo(new CustomerInfoCallback(
            onReceived: info => tcs.TrySetResult(info.ActiveSubscriptions.Count > 0),
            onError: _ => tcs.TrySetResult(false)));
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
