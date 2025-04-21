// Ignore Spelling: api
using Microsoft.Extensions.Caching.Memory;
using System.Runtime.CompilerServices;
using System.Collections.Concurrent;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Principal;
using System.Text;

namespace Bb.Services
{

    /// <summary>
    /// Provides methods for validating JWT tokens and retrieving tokens based on API keys.
    /// </summary>
    public class TokenProvider
    {

        /// <summary>
        /// Validates a JWT token and returns the associated principal.
        /// </summary>
        /// <param name="token">The JWT token to validate. Must not be null or empty.</param>
        /// <param name="secretKey">The secret key used to validate the token signature. Must not be null or empty.</param>
        /// <param name="validIssuer">The expected issuer of the token. Must not be null or empty.</param>
        /// <param name="validAudience">The expected audience of the token. Must not be null or empty.</param>
        /// <returns>An <see cref="IPrincipal"/> representing the validated token's claims, or null if validation fails.</returns>
        /// <remarks>
        /// This method validates the provided JWT token using the specified secret key, issuer, and audience.
        /// </remarks>
        /// <exception cref="ArgumentNullException">
        /// Thrown if any of the parameters are null or empty.
        /// </exception>
        /// <example>
        /// <code lang="C#">
        /// var principal = TokenProvider.ValidateToken("jwtToken", "mySecretKey", "myIssuer", "myAudience");
        /// if (principal != null)
        /// {
        ///     // Token is valid
        /// }
        /// else
        /// {
        ///     // Token is invalid
        /// }
        /// </code>
        /// </example>
        public static IPrincipal? ValidateToken(string token, string secretKey, string validIssuer, string validAudience)
        {

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(secretKey);

            var validationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = validIssuer,
                ValidAudience = validAudience,
                IssuerSigningKey = new SymmetricSecurityKey(key)
            };

            SecurityToken validatedToken;
            var principal = tokenHandler.ValidateToken(token, validationParameters, out validatedToken);

            return principal;

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenProvider"/> class with the specified cache and token resolver.
        /// </summary>
        /// <param name="cache"></param>
        /// <param name="resolver"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public TokenProvider(IMemoryCache cache, TokenResolver resolver)
        {
            _cache = cache ?? throw new ArgumentNullException(nameof(cache));
            _resolver = resolver;
            _lockObjects = new ConcurrentDictionary<string, SemaphoreSlim>();
        }

        /// <summary>
        /// Retrieves a token asynchronously for the specified API key.
        /// </summary>
        /// <param name="apiKey">The API key for which to retrieve the token. Must not be null or empty.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the asynchronous operation, with a result of the token as a string.</returns>
        /// <remarks>
        /// This method retrieves a token from the cache if available, or fetches it from the token resolver if not.
        /// </remarks>
        /// <exception cref="UnauthorizedAccessException">
        /// Thrown if the API key is invalid.
        /// </exception>
        /// <example>
        /// <code lang="C#">
        /// var tokenProvider = new TokenProvider(memoryCache, tokenResolver);
        /// var token = await tokenProvider.GetTokenAsync("myApiKey");
        /// </code>
        /// </example>
        public async Task<string?> GetTokenAsync(string? apiKey)
        {

            if (apiKey == null)
                return null;

            if (_cache.TryGetValue(apiKey, out string? token))   // Check cache first.
                return token;

            // Get a lock for the apikey
            var lockObj = _lockObjects.GetOrAdd(apiKey, _ => new SemaphoreSlim(1, 1));

            try
            {

                await lockObj.WaitAsync();

                if (_cache.TryGetValue(apiKey, out token))
                    return token;

                token = await Fetch(apiKey);

            }
            finally
            {
                lockObj.Release();
                _ = Task.Run(() => Unlock(apiKey));
            }

            return token;

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void Unlock(string apiKey)
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
        }

        /// <summary>
        /// Fetches a token from the token resolver for the specified API key.
        /// </summary>
        /// <param name="apiKey">The API key for which to fetch the token. Must not be null or empty.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the asynchronous operation, with a result of the token as a string.</returns>
        /// <remarks>
        /// This method generates credentials from the API key, retrieves the token from the token resolver, and caches it.
        /// </remarks>
        /// <exception cref="UnauthorizedAccessException">
        /// Thrown if the API key is invalid.
        /// </exception>
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

    }


}
