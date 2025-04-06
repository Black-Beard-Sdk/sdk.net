using Bb.Http;
using Bb.Urls;
using RestSharp;

namespace Bb.Helpers
{

    /// <summary>
    /// Extension methods for the <see cref="RestClient"/> class.
    /// </summary>
    public static class RestClientExtension
    {        

        /// <summary>
        /// Retrieves an authentication token asynchronously using the specified credentials.
        /// </summary>
        /// <param name="self">The <see cref="RestClient"/> instance to use for the request. Must not be null.</param>
        /// <param name="path">The endpoint path for the token request. Must not be null or empty.</param>
        /// <param name="client_id">The client ID for authentication. Must not be null or empty.</param>
        /// <param name="client_secret">The client secret for authentication. Can be null or empty.</param>
        /// <param name="username">The username for authentication. Must not be null or empty.</param>
        /// <param name="password">The password for authentication. Must not be null or empty.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the asynchronous operation, with a result of <see cref="TokenResponse"/> containing the token details.</returns>
        /// <remarks>
        /// This method sends a POST request to the specified endpoint to retrieve an authentication token using the provided credentials.
        /// </remarks>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="self"/>, <paramref name="path"/>, <paramref name="client_id"/>, <paramref name="username"/>, or <paramref name="password"/> is null or empty.
        /// </exception>
        /// <exception cref="Exception">
        /// Thrown if the token request fails or the response is not successful.
        /// </exception>
        /// <example>
        /// <code lang="C#">
        /// var client = new RestClient("https://example.com");
        /// var tokenResponse = await client.GetTokenAsync("/token", "myClientId", "myClientSecret", "myUsername", "myPassword");
        /// </code>
        /// </example>
        public static async Task<TokenResponse?> GetTokenAsync(this RestClient self, string path, string client_id, string client_secret, string username, string password)
        {
            var request = Method.Post.NewRequest(path, DataFormat.Json)
                   .AddParameter("client_id", client_id)    // Add form parameters
                   .AddParameter("username", username)
                   .AddParameter("password", password)
                   .AddParameter("grant_type", "password");

            if (!string.IsNullOrEmpty(client_secret))
                request.AddParameter("client_secret", client_secret);

            var response = await self.ExecuteAsync<TokenResponse>(request);

            if (!response.IsSuccessful)
                throw new Exception($"Failed to retrieve token: {response.ErrorMessage ?? response.StatusDescription}");

            return response.Data;
        }

    }

}
