using Bb.Exceptions;
using Bb.Policies;
using Bb.Policies.Asts;
using Microsoft.AspNetCore.Authorization;
using System.Reflection;

namespace Bb.Extensions
{


    /// <summary>
    /// Extension methods for configuring policies in a web application.
    /// </summary>
    public static class PolicyExtension
    {

        

        static PolicyExtension()
        {

            _logger = new Logger<WebApplication>(new LoggerFactory());

        }

        /// <summary>
        /// Appends policies from the specified file.
        /// </summary>
        /// <param name="builder">The <see cref="WebApplicationBuilder"/> instance to configure. Must not be null.</param>
        /// <param name="filePath">The path to the policy file. Must not be null or empty.</param>
        /// <param name="filter">An optional filter function to apply to policy rules. Can be null.</param>
        /// <param name="configureAction">An optional action to configure authorization options. Can be null.</param>
        /// <returns>The configured <see cref="WebApplicationBuilder"/> instance.</returns>
        /// <remarks>
        /// This method parses a policy file, evaluates its rules, and registers them into the application's authorization system.
        /// </remarks>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="filePath"/> is null.
        /// </exception>
        /// <exception cref="FileNotFoundException">
        /// Thrown if the specified policy file does not exist.
        /// </exception>
        /// <exception cref="Exception">
        /// Thrown if the policy file fails to evaluate successfully.
        /// </exception>
        /// <example>
        /// <code lang="C#">
        /// var builder = WebApplication.CreateBuilder(args);
        /// builder.AddPolicy("policies.json", rule => rule.Name.StartsWith("Admin"), options => options.InvokeHandlersAfterFailure = true);
        /// var application = builder.Build();
        /// application.Run();
        /// </code>
        /// </example>
        public static WebApplicationBuilder AddPolicy(this WebApplicationBuilder builder, string filePath, Func<PolicyRule, bool>? filter = null, Action<AuthorizationOptions>? configureAction = null)
        {

            if (filePath == null)
                throw new ArgumentNullException(nameof(filePath));

            if (!File.Exists(filePath))
                throw new FileNotFoundException(filePath);

            var services = builder.Services;

            PolicyContainer policies = Policy.ParsePath(filePath);
            if (!policies.Diagnostics.Success)
                throw new PolicyEvaluationException("Failed to evaluate file policies");
            var evaluator = new PolicyEvaluator(policies);

            services.AddSingleton(evaluator);
            var items = GetAuthorizePoliciesFromAssemblies().ToList();

            services.AddAuthorization(options =>
            {
                AddAuthorisation(filter, configureAction, options, policies, evaluator, items);

            });

            return builder;

        }

        private static void AddAuthorisation(Func<PolicyRule, bool>? filter, Action<AuthorizationOptions>? configureAction, AuthorizationOptions options, PolicyContainer policies, PolicyEvaluator evaluator, List<string> items)
        {
            ManageDefaults(options, policies, evaluator);

            foreach (var policyRule in policies.Rules)
                if (filter != null && filter(policyRule))
                    options.AddPolicy(policyRule.Name, policy =>
                    {

                        if (items.Contains(policyRule.Name))
                            items.Remove(policyRule.Name);

                        policy.RequireAssertion(c => evaluator.Evaluate(policyRule.Name, c.User, out RuntimeContext context));

                    });

            if (configureAction != null)
                configureAction(options);

            foreach (var item in items)
                _logger.LogDebug("Policy {policy} not found in policies file", item);
        }

        /// <summary>
        /// Configures the policy evaluator service.
        /// </summary>
        /// <param name="application">The <see cref="WebApplication"/> instance to configure. Must not be null.</param>
        /// <returns>The configured <see cref="WebApplication"/> instance.</returns>
        /// <remarks>
        /// This method sets up the policy evaluator service and enables authentication and authorization middleware in the application.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var builder = WebApplication.CreateBuilder(args);
        /// var app = builder.Build();
        /// app.ConfigurePolicy();
        /// app.Run();
        /// </code>
        /// </example>
        public static WebApplication ConfigurePolicy(this WebApplication application)
        {
            
            var evaluator = application.Services.GetRequiredService<PolicyEvaluator>();
            evaluator.ServiceProvider = application.Services.GetRequiredService<IServiceProvider>();

            application.UseAuthentication();
            application.UseAuthorization();

            return application;
        }

        /// <summary>
        /// Retrieves all policy names from <see cref="AuthorizeAttribute"/> across all loaded assemblies.
        /// </summary>
        /// <returns>A list of unique policy names.</returns>
        /// <remarks>
        /// This method scans all loaded assemblies for <see cref="AuthorizeAttribute"/> applied to types, methods, and properties, and collects their policy names.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var policies = PolicyExtension.GetAuthorizePoliciesFromAssemblies();
        /// foreach (var policy in policies)
        /// {
        ///     Console.WriteLine($"Policy: {policy}");
        /// }
        /// </code>
        /// </example>
        public static IEnumerable<string> GetAuthorizePoliciesFromAssemblies()
        {

            var policies = new HashSet<string>();

            var bindings = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                try
                {
                    // Check assembly types
                    foreach (var type in assembly.GetTypes())
                    {
                        // Check type-level attributes
                        CollectPoliciesFromAttributes(type.GetCustomAttributes<AuthorizeAttribute>(), policies);

                        // Check method-level attributes
                        foreach (var method in type.GetMethods(bindings))
                            CollectPoliciesFromAttributes(method.GetCustomAttributes<AuthorizeAttribute>(), policies);

                        // Check property-level attributes
                        foreach (var property in type.GetProperties(bindings))
                            CollectPoliciesFromAttributes(property.GetCustomAttributes<AuthorizeAttribute>(), policies);

                    }
                }
                catch (ReflectionTypeLoadException)
                {
                    // Skip assemblies that cannot be loaded
                    continue;
                }
                catch (Exception)
                {
                    // Skip any other exceptions during reflection
                    continue;
                }
            }

            return policies;

        }


        private static void ManageDefaults(AuthorizationOptions options, PolicyContainer policies, PolicyEvaluator evaluator)
        {
            if (policies.DefaultRule != null)
            {
                options.DefaultPolicy = new AuthorizationPolicyBuilder()
                    .RequireAssertion((c) => evaluator.Evaluate("default", c.User, out RuntimeContext context))
                    .Build();
            }

            if (policies.FallbackRule != null)
            {
                options.FallbackPolicy = new AuthorizationPolicyBuilder()
                    .RequireAssertion((c) => evaluator.Evaluate("fallback", c.User, out RuntimeContext context))
                    .Build();
            }
            else if (policies.DefaultRule != null)
                options.FallbackPolicy = options.DefaultPolicy;

        
        }


        private static void CollectPoliciesFromAttributes(IEnumerable<AuthorizeAttribute> attributes, HashSet<string> policies)
        {
            foreach (var attribute in attributes)
                if (!string.IsNullOrEmpty(attribute.Policy))
                    policies.Add(attribute.Policy);
        }


        private static readonly Logger<WebApplication> _logger;

    }


}
