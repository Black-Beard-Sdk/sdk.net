// Ignore Spelling: Blazor

using Bb.ComponentModel;
using Bb.ComponentModel.Attributes;

namespace Bb.Loaders
{

    /// <summary>
    /// Initializes the web application builder for Blazor components.
    /// </summary>
    [ExposeClass(ConstantsCore.Initialization, ExposedType = typeof(IInjectBuilder<WebApplicationBuilder>), LifeCycle = IocScope.Transiant)]
    public class BlazorBuilderInitializer : InjectBuilder<WebApplicationBuilder>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BlazorBuilderInitializer"/> class.
        /// </summary>
        public BlazorBuilderInitializer()
        {
        }

        /// <summary>
        /// Determines whether the builder can execute in the given context.
        /// </summary>
        /// <param name="context">The context in which the builder is being executed. Must not be null.</param>
        /// <returns><see langword="true"/> if the builder can execute in the given context; otherwise, <see langword="false"/>.</returns>
        /// <remarks>
        /// This method checks if the builder is allowed to execute based on the provided context.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var initializer = new BlazorBuilderInitializer();
        /// bool canExecute = initializer.CanExecute(context);
        /// Console.WriteLine($"Can execute: {canExecute}");
        /// </code>
        /// </example>
        public override bool CanExecute(object context)
        {
            return base.CanExecute(context);
        }

        /// <summary>
        /// Executes the builder to configure the web application builder for Blazor.
        /// </summary>
        /// <param name="builder">The <see cref="WebApplicationBuilder"/> instance to configure. Must not be null.</param>
        /// <returns><see langword="null"/> after configuring the builder.</returns>
        /// <remarks>
        /// This method configures the web application builder by adding Razor components, interactive server components, Razor pages, and server-side Blazor support.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var builder = WebApplication.CreateBuilder(args);
        /// var initializer = new BlazorBuilderInitializer();
        /// initializer.Execute(builder);
        /// var app = builder.Build();
        /// app.Run();
        /// </code>
        /// </example>
        public override void Execute(WebApplicationBuilder builder)
        {

            var services = builder.Services;
            
            services.AddRazorComponents()
                .AddInteractiveServerComponents();

            services.AddRazorPages();
            services.AddServerSideBlazor();

        }

        /// <summary>
        /// Gets or sets a value indicating whether Blazor initialization is enabled.
        /// </summary>
        /// <value><see langword="true"/> if Blazor initialization is enabled; otherwise, <see langword="false"/>.</value>
        /// <remarks>
        /// This property is injected by the IoC container and determines whether Blazor initialization should be performed.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var initializer = new BlazorBuilderInitializer();
        /// Console.WriteLine($"Initialize Blazor: {initializer.Initialize}");
        /// </code>
        /// </example>
        [InjectValueByIoc("InitializeBlazor")]
        public bool Initialize { get; set; }

    }


}
