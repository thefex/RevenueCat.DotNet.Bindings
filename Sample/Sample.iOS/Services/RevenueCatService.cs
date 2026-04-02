using Sample.Core.Services;

namespace Sample.iOS.Services;

public class RevenueCatService : IRevenueCatService
{
    public Task<bool> IsPremiumAsync()
    {
        var tcs = new TaskCompletionSource<bool>();

        RevenueCat.RCPurchases.SharedPurchases.GetCustomerInfoWithCompletion((customerInfo, error) =>
        {
            if (error != null)
            {
                tcs.TrySetResult(false);
                return;
            }

            tcs.TrySetResult(customerInfo?.ActiveSubscriptions?.Count > 0);
        });

        return tcs.Task;
    }
}
