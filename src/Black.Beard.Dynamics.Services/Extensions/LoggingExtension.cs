using Bb.ComponentModel.Loaders;


namespace Bb.Extensions
{


    public static class LoggingExtension
    {


        public static WebApplicationBuilder ConfigureTrace(this WebApplicationBuilder builder)
        {

            builder.WebHost.ConfigureLogging(logging =>
            {
                var services = builder.Services.BuildServiceProvider();
                var i = logging.AutoConfigure(services);
            });

            return builder;

        }

    }


}
