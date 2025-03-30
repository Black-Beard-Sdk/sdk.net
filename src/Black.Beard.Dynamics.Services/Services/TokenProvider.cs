using Microsoft.Extensions.Caching.Memory;
using System.Runtime.CompilerServices;
using System.Collections.Concurrent;

namespace Bb.Services
{

    public class TokenProvider
    {

        public TokenProvider(IMemoryCache cache, TokenResolver resolver)
        {
            _cache = cache ?? throw new ArgumentNullException(nameof(cache));
            _resolver = resolver;
            _lockObjects = new ConcurrentDictionary<string, SemaphoreSlim>();
        }

        public async Task<string> GetTokenAsync(string apiKey)
        {

            if (_cache.TryGetValue(apiKey, out string token))   // Check cache first.
            {

                // Get a lock for the apikey
                var lockObj = _lockObjects.GetOrAdd(apiKey, _ => new SemaphoreSlim(1, 1));

                try
                {

                    await lockObj.WaitAsync();

                    if (_cache.TryGetValue(apiKey, out token))
                        return token;

                    token = await Fetch(apiKey);

                    return token;

                }
                finally
                {

                    lockObj.Release();
                    _ = Task.Run(() =>
                    {
                        try
                        {
                            if (_lockObjects.TryRemove(apiKey, out var semaphore))
                                semaphore.Dispose();
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.Debug.WriteLine($"Failed to cleanup: {ex.Message}");
                        }
                    });


                }

            }

            return token;

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private async Task<string> Fetch(string apiKey)
        {

            var credentials = ApiKeyGenerator.GenerateIdentifiers(apiKey);
            if (credentials == null)
                throw new UnauthorizedAccessException("Invalid apiKey");

            var tokenResponse = await _resolver.GeTokenAsync(credentials[1], credentials[2]);

            var expirationTime = TimeSpan.FromSeconds(tokenResponse.ExpiresIn - 1);

            _cache.Set(apiKey, tokenResponse.AccessToken, expirationTime);

            return tokenResponse.AccessToken;

        }

        private readonly IMemoryCache _cache;
        private readonly TokenResolver _resolver;
        private readonly ConcurrentDictionary<string, SemaphoreSlim> _lockObjects;
        private HashSet<string> strings = new HashSet<string>();
        private volatile object _lock = new object();

    }


}
