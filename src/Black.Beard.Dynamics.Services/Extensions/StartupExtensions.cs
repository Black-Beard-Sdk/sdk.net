using Bb.ComponentModel.Factories;
using ICSharpCode.Decompiler.CSharp.Syntax;

namespace Bb.Extensions
{
    public static class StartupExtensions
    {



        public static bool TestExist<T> (this IServiceCollection self)
        {
      
            return self.Where(c => c.ServiceType == typeof(T)).Any();
        }



//public static WebApplicationBuilder Use<TStartup>(this WebApplicationBuilder builder, TStartup startup, LocalServiceProvider serviceProvider, Func<TStartup, Delegate> func)
//{

//    var configureServicesMethod = func.Method;

//    //var configureServicesMethod = typeof(TStartup).GetMethod("ConfigureServices");
//    if (configureServicesMethod != null)
//    {
//        var args = ResolveParameters(serviceProvider, configureServicesMethod);
//        configureServicesMethod.Invoke(startup, args);
//    }
//    return builder;
//}

public static WebApplicationBuilder UseStartup<TStartup>(this WebApplicationBuilder builder, TStartup startup, LocalServiceProvider serviceProvider)
        {
            var configureServicesMethod = typeof(TStartup).GetMethod("ConfigureServices");
            if (configureServicesMethod != null)
            {
                var args = ResolveParameters(serviceProvider, configureServicesMethod);
                configureServicesMethod.Invoke(startup, args);
            }
            return builder;
        }

        public static WebApplication UseStartupConfigure<TStartup>(this WebApplication app, TStartup startup, LocalServiceProvider serviceProvider)
        {
            var configureMethod = typeof(TStartup).GetMethod("Configure");
            if (configureMethod != null)
            {
                var args = ResolveParameters(serviceProvider, configureMethod);
                configureMethod.Invoke(startup, new object[] { app, app.Environment });
            }
            return app;
        }

        private static object[] ResolveParameters(LocalServiceProvider serviceProvider, System.Reflection.MethodInfo configureServicesMethod)
        {
            var parameters = configureServicesMethod.GetParameters();
            List<object> args = new List<object>(parameters.Length);
            foreach (var item in parameters)
                args.Add(serviceProvider.GetService(item.ParameterType));
            return args.ToArray();
        }


    }


}
