using Bb.ComponentModel;
using Bb.ComponentModel.Attributes;
using Bb.Loaders.Extensions;

namespace Bb.Loaders
{


    [ExposeClass(ConstantsCore.Initialization, ExposedType = typeof(IInjectBuilder<WebApplicationBuilder>), LifeCycle = IocScopeEnum.Transiant)]
    public class WebApplicationBuilderIocInitializer : InjectBuilder<WebApplicationBuilder>
    {

        public WebApplicationBuilderIocInitializer()
        {

        }

        public override object Execute(WebApplicationBuilder builder)
        {

            builder.SetAllIoc((c, d) => true);
            return null;

        }


    }


}
