namespace Sample.Core.Services;

public interface IRevenueCatService
{
    Task<bool> IsPremiumAsync();
}
