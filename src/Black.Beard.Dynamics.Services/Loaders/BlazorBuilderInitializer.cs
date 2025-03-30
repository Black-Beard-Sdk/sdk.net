using Bb.ComponentModel;
using Bb.ComponentModel.Attributes;

namespace Bb.Loaders
{
    [ExposeClass(ConstantsCore.Initialization, ExposedType = typeof(IInjectBuilder<WebApplicationBuilder>), LifeCycle = IocScopeEnum.Transiant)]
    public class BlazorBuilderInitializer : InjectBuilder<WebApplicationBuilder>
    {

        public BlazorBuilderInitializer()
        {
        }

        public override bool CanExecute(object context)
        {
            return base.CanExecute(context);
        }

        public override object Execute(WebApplicationBuilder builder)
        {

            var services = builder.Services;
            
            services.AddRazorComponents()
                .AddInteractiveServerComponents();

            services.AddRazorPages();
            services.AddServerSideBlazor();

            return null;

        }

        [InjectValueByIoc("InitializeBlazor")]
        public bool Initialize { get; set; }

    }


}
