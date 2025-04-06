namespace Bb.Models
{




    /// <summary>
    /// Represents the options for configuring bearer token authentication.
    /// </summary>
    public class BearerOption
    {

        /// <summary>
        /// Gets or sets the name of the bearer option configuration.
        /// </summary>
        /// <value>A <see cref="string"/> representing the name of the configuration.</value>
        /// <remarks>
        /// This property is used to identify the specific bearer option configuration in the application.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var bearerOption = new BearerOption();
        /// bearerOption.Name = "MyBearerOption";
        /// Console.WriteLine($"Bearer Option Name: {bearerOption.Name}");
        /// </code>
        /// </example>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the issuer should be validated.
        /// </summary>
        /// <value><see langword="true"/> if the issuer should be validated; otherwise, <see langword="false"/>.</value>
        /// <remarks>
        /// This property determines whether the token's issuer is validated during authentication.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var bearerOption = new BearerOption();
        /// bearerOption.ValidateIssuer = true;
        /// Console.WriteLine($"Validate Issuer: {bearerOption.ValidateIssuer}");
        /// </code>
        /// </example>
        public bool ValidateIssuer { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether the audience should be validated.
        /// </summary>
        /// <value><see langword="true"/> if the audience should be validated; otherwise, <see langword="false"/>.</value>
        /// <remarks>
        /// This property determines whether the token's audience is validated during authentication.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var bearerOption = new BearerOption();
        /// bearerOption.ValidateAudience = true;
        /// Console.WriteLine($"Validate Audience: {bearerOption.ValidateAudience}");
        /// </code>
        /// </example>
        public bool ValidateAudience { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether the token's lifetime should be validated.
        /// </summary>
        /// <value><see langword="true"/> if the token's lifetime should be validated; otherwise, <see langword="false"/>.</value>
        /// <remarks>
        /// This property determines whether the token's expiration time is validated during authentication.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var bearerOption = new BearerOption();
        /// bearerOption.ValidateLifetime = true;
        /// Console.WriteLine($"Validate Lifetime: {bearerOption.ValidateLifetime}");
        /// </code>
        /// </example>
        public bool ValidateLifetime { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether the issuer signing key should be validated.
        /// </summary>
        /// <value><see langword="true"/> if the issuer signing key should be validated; otherwise, <see langword="false"/>.</value>
        /// <remarks>
        /// This property determines whether the token's signing key is validated during authentication.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var bearerOption = new BearerOption();
        /// bearerOption.ValidateIssuerSigningKey = true;
        /// Console.WriteLine($"Validate Issuer Signing Key: {bearerOption.ValidateIssuerSigningKey}");
        /// </code>
        /// </example>
        public bool ValidateIssuerSigningKey { get; set; } = true;

        /// <summary>
        /// Gets or sets the valid issuer for the token.
        /// </summary>
        /// <value>A <see cref="string"/> representing the valid issuer.</value>
        /// <remarks>
        /// This property specifies the expected issuer of the token during validation.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var bearerOption = new BearerOption();
        /// bearerOption.ValidIssuer = "https://myissuer.com";
        /// Console.WriteLine($"Valid Issuer: {bearerOption.ValidIssuer}");
        /// </code>
        /// </example>
        public string ValidIssuer { get; set; } = "true";

        /// <summary>
        /// Gets or sets the valid audience for the token.
        /// </summary>
        /// <value>A <see cref="string"/> representing the valid audience.</value>
        /// <remarks>
        /// This property specifies the expected audience of the token during validation.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var bearerOption = new BearerOption();
        /// bearerOption.ValidAudience = "https://myaudience.com";
        /// Console.WriteLine($"Valid Audience: {bearerOption.ValidAudience}");
        /// </code>
        /// </example>
        public string ValidAudience { get; set; } = "true";

        /// <summary>
        /// Gets or sets the issuer signing key for the token.
        /// </summary>
        /// <value>A <see cref="string"/> representing the issuer signing key.</value>
        /// <remarks>
        /// This property specifies the key used to validate the token's signature.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var bearerOption = new BearerOption();
        /// bearerOption.IssuerSigningKey = "my-signing-key";
        /// Console.WriteLine($"Issuer Signing Key: {bearerOption.IssuerSigningKey}");
        /// </code>
        /// </example>
        public string IssuerSigningKey { get; set; } = "true";

    }


}
