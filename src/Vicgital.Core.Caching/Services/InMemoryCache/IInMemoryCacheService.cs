namespace Vicgital.Core.Caching.Services.InMemoryCache
{
    public interface IInMemoryCacheService
    {
        T? Get<T>(string key);
        T? Add<T>(string key, T value, DateTimeOffset expiresAt);
        T? Add<T>(string key, T value, TimeSpan absoluteExpirationRelativeToNow);
        void Remove(string key);
    }
}
