using Bb.ComponentModel;
using Bb.ComponentModel.Attributes;
using Bb.Extensions;

namespace Bb.Loaders
{


    /// <summary>
    /// Initializer
    /// </summary>
    [ExposeClass(ConstantsCore.Initialization, ExposedType = typeof(IInjectBuilder<WebApplicationBuilder>), LifeCycle = IocScopeEnum.Transiant)]
    public class WebApplicationBuilderIocInitializer : InjectBuilder<WebApplicationBuilder>
    {


        /// <summary>
        /// Executes the IoC initializer for the web application builder.
        /// </summary>
        /// <param name="builder">The <see cref="WebApplicationBuilder"/> instance to configure. Must not be null.</param>
        /// <returns><see langword="null"/> after configuring the builder.</returns>
        /// <remarks>
        /// This method configures the web application builder by setting up dependency injection for all discovered types using the IoC container.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var builder = WebApplication.CreateBuilder(args);
        /// var initializer = new WebApplicationBuilderIocInitializer();
        /// initializer.Execute(builder);
        /// var app = builder.Build();
        /// app.Run();
        /// </code>
        /// </example>
        public override void Execute(WebApplicationBuilder builder)
        {

            builder.SetAllIoc((c, d) => true);

        }


    }


}
