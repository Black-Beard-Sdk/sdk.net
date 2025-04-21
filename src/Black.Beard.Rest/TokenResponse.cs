using System.Text.Json.Serialization;

namespace Bb.Http
{
    /// <summary>
    /// Represents the response containing token information from an authentication server.
    /// </summary>
    /// <remarks>
    /// This object is typically used to deserialize the JSON response from an OAuth2 or OpenID Connect token endpoint.
    /// </remarks>
    public record TokenResponse
    {
        /// <summary>
        /// Gets the access token issued by the authorization server.
        /// </summary>
        /// <remarks>
        /// This token is used to authenticate API requests.
        /// </remarks>
        [JsonPropertyName("access_token")]
        public string AccessToken { get; init; }

        /// <summary>
        /// Gets the duration in seconds for which the access token is valid.
        /// </summary>
        /// <remarks>
        /// After this duration, the access token will expire and a new one must be obtained.
        /// </remarks>
        [JsonPropertyName("expires_in")]
        public int ExpiresIn { get; init; }

        /// <summary>
        /// Gets the refresh token issued by the authorization server.
        /// </summary>
        /// <remarks>
        /// This token can be used to obtain a new access token without requiring user authentication.
        /// </remarks>
        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; init; }

        /// <summary>
        /// Gets the duration in seconds for which the refresh token is valid.
        /// </summary>
        /// <remarks>
        /// After this duration, the refresh token will expire and a new one must be obtained.
        /// </remarks>
        [JsonPropertyName("refresh_expires_in")]
        public int RefreshExpiresIn { get; init; }

        /// <summary>
        /// Gets the type of the token issued.
        /// </summary>
        /// <remarks>
        /// Typically, this is "Bearer".
        /// </remarks>
        [JsonPropertyName("token_type")]
        public string TokenType { get; init; }

        /// <summary>
        /// Gets the "not-before" policy timestamp.
        /// </summary>
        /// <remarks>
        /// This indicates the time before which the token must not be accepted.
        /// </remarks>
        [JsonPropertyName("not-before-policy")]
        public int NotBeforePolicy { get; init; }

        /// <summary>
        /// Gets the session state identifier.
        /// </summary>
        /// <remarks>
        /// This is used to track the session state of the user.
        /// </remarks>
        [JsonPropertyName("session_state")]
        public string SessionState { get; init; }

        /// <summary>
        /// Gets the scope of the access token.
        /// </summary>
        /// <remarks>
        /// This defines the permissions granted by the token.
        /// </remarks>
        [JsonPropertyName("scope")]
        public string Scope { get; init; }
    }
}
