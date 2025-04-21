
using Bb.Http;
using Bb.Services;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.IdentityModel.Tokens;
using Moq;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Black.Beard.Dynamics.Services.Tests
{
    public class TokenProviderTests
    {
        private readonly Mock<IMemoryCache> _mockCache;
        private readonly Mock<TokenResolver> _mockResolver;
        private readonly TokenProvider _tokenProvider;

        public TokenProviderTests()
        {
            _mockCache = new Mock<IMemoryCache>();
            _mockResolver = new Mock<TokenResolver>(null, null); // Simulez les dépendances nécessaires pour TokenResolver
            _tokenProvider = new TokenProvider(_mockCache.Object, _mockResolver.Object);
        }


        private static string? GetToken(string secretKey, string validIssuer, string validAudience)
        {
            // Arrange
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(secretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(),
                Expires = DateTime.UtcNow.AddMinutes(5),
                Issuer = validIssuer,
                Audience = validAudience,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var securityToken = tokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = tokenHandler.WriteToken(securityToken);

            return jwtToken;

        }

        #region ValidateToken Tests

        [Fact]
        public void ValidateToken_ValidToken_ReturnsPrincipal()
        {
            var secretKey = "mySecretKey";
            var validIssuer = "myIssuer";
            var validAudience = "myAudience";

            var jwtToken = GetToken(secretKey, validIssuer, validAudience);

            // Act
            var principal = TokenProvider.ValidateToken(jwtToken, secretKey, validIssuer, validAudience);

            // Assert
            Assert.NotNull(principal);
        }

        [Fact]
        public void ValidateToken_InvalidToken_ThrowsException()
        {
            // Arrange
            var token = "invalidToken";
            var secretKey = "mySecretKey";
            var validIssuer = "myIssuer";
            var validAudience = "myAudience";

            // Act & Assert
            Assert.Throws<SecurityTokenException>(() =>
                TokenProvider.ValidateToken(token, secretKey, validIssuer, validAudience));
        }

        #endregion

        #region GetTokenAsync Tests

        [Fact]
        public async Task GetTokenAsync_TokenInCache_ReturnsCachedToken()
        {
            // Arrange
            var apiKey = "testApiKey";
            var cachedToken = "cachedToken";

            _mockCache.Setup(c => c.TryGetValue(apiKey, out cachedToken)).Returns(true);

            // Act
            var token = await _tokenProvider.GetTokenAsync(apiKey);

            // Assert
            Assert.Equal(cachedToken, token);
            _mockCache.Verify(c => c.TryGetValue(apiKey, out cachedToken), Times.Once);
        }

        [Fact]
        public async Task GetTokenAsync_TokenNotInCache_FetchesToken()
        {
            // Arrange
            var apiKey = "testApiKey";
            var fetchedToken = "fetchedToken";
            var tokenResponse = new TokenResponse
            {
                AccessToken = fetchedToken,
                ExpiresIn = 3600
            };

            _mockCache.Setup(c => c.TryGetValue(apiKey, out It.Ref<string?>.IsAny)).Returns(false);
            _mockResolver.Setup(r => r.GeTokenAsync(It.IsAny<string>(), It.IsAny<string>()))
                         .ReturnsAsync(tokenResponse);

            // Act
            var token = await _tokenProvider.GetTokenAsync(apiKey);

            // Assert
            Assert.Equal(fetchedToken, token);
            _mockCache.Verify(c => c.Set(apiKey, fetchedToken, It.IsAny<TimeSpan>()), Times.Once);
        }

        [Fact]
        public async Task GetTokenAsync_InvalidApiKey_ThrowsUnauthorizedAccessException()
        {
            // Arrange
            var apiKey = "invalidApiKey";

            _mockCache.Setup(c => c.TryGetValue(apiKey, out It.Ref<string?>.IsAny)).Returns(false);
            _mockResolver.Setup(r => r.GeTokenAsync(It.IsAny<string>(), It.IsAny<string>()))
                         .ThrowsAsync(new UnauthorizedAccessException());

            // Act & Assert
            await Assert.ThrowsAsync<UnauthorizedAccessException>(() => _tokenProvider.GetTokenAsync(apiKey));
        }

        #endregion
    }
}


