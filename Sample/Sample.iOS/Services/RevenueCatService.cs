using Microsoft.Extensions.Logging;
using Sample.Core.Services;

namespace Sample.iOS.Services;

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
        RevenueCat.RCPurchases.SharedPurchases.GetCustomerInfoWithCompletion((customerInfo, error) =>
        {
            if (error != null)
            {
                _logger.LogError("Failed to fetch customer info: {Error}", error.LocalizedDescription);
                tcs.TrySetResult(false);
                return;
            }

            var activeCount = customerInfo?.ActiveSubscriptions?.Count ?? 0;
            var isPremium = activeCount > 0;
            _logger.LogInformation(
                "Customer info received. ActiveSubscriptions={Count}, IsPremium={IsPremium}",
                activeCount, isPremium);
            tcs.TrySetResult(isPremium);
        });

        return tcs.Task;
    }
}
