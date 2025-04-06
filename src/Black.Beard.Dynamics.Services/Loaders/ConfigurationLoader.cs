using Bb.ComponentModel;
using Bb.ComponentModel.Attributes;
using Bb.Configuration.Git;
using Bb.Configurations;
using Bb.Extensions;
using System.Diagnostics;
using System.Reflection;

namespace Bb.Loaders
{


    /// <summary>
    /// Download configuration form git repository and load the configuration
    /// </summary>
    [ExposeClass(ConstantsCore.Initialization, ExposedType = typeof(IInjectBuilder<WebApplicationBuilder>), LifeCycle = IocScopeEnum.Transiant)]
    [Priority(1)]
    public class ConfigurationLoader : InjectBuilder<WebApplicationBuilder>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationLoader"/> class.
        /// </summary>
        public ConfigurationLoader()
        {

        }

        /// <summary>
        /// Executes the configuration loader to download and load configurations from a Git repository.
        /// </summary>
        /// <param name="context">The <see cref="WebApplicationBuilder"/> instance to configure. Must not be null.</param>
        /// <returns><see langword="null"/> after executing the configuration loader.</returns>
        /// <remarks>
        /// This method downloads configuration files from a Git repository based on the provided configuration path and loads them into the application context.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var builder = WebApplication.CreateBuilder(args);
        /// var loader = new ConfigurationLoader();
        /// loader.Execute(builder);
        /// var app = builder.Build();
        /// app.Run();
        /// </code>
        /// </example>
        public override void Execute(WebApplicationBuilder context)
        {

            context.LoadConfiguration(Environment.CurrentDirectory);
            context.LoadConfiguration(Assembly.GetEntryAssembly().GetDirectory().FullName);
            context.LoadConfiguration(Assembly.GetExecutingAssembly().GetDirectory().FullName);

            if (InternetConnectivityChecker.IsConnected)
            {

                if (ConfigurationPath != null)
                {
                    var remoteUrl = ConfigurationPath["url"];
                    if (!string.IsNullOrEmpty(remoteUrl))
                    {

                        var userName = ConfigurationPath.ContainsKey(_user) ? ConfigurationPath[_user] : string.Empty;
                        var email = ConfigurationPath.ContainsKey(_email) ? ConfigurationPath[_email] : string.Empty;
                        var pwd = ConfigurationPath.ContainsKey(_pwd) ? ConfigurationPath[_pwd] : string.Empty;

                        var git = new GitConfiguration(remoteUrl, userName, email, pwd);
                        if (git.IsValid())
                        {


                            var branch = ConfigurationPath.ContainsKey(_branch)
                                ? ConfigurationPath[_branch]
                                : string.Empty;

                            if (!string.IsNullOrEmpty(branch))
                                git.GitBranch = branch;

                            var folder = ConfigurationPath.ContainsKey(_folder)
                                ? Environment.CurrentDirectory.Combine(ConfigurationPath[_folder])
                                : Environment.CurrentDirectory.Combine("Config");

                            folder = folder.Combine("Current");
                            var dir = folder.AsDirectory();

                            // 
                            var loader = new Bb.Configuration.Git.ConfigurationLoader(git);

                            dir.Refresh();
                            if (dir.Exists)
                            {
                                var branchName = loader.GetLocalBranchName(folder);
                                if (branch != branchName)
                                {
                                    dir.DeleteFolderIfExists();
                                    dir.Refresh();
                                }
                            }

                            if (loader.Refresh(folder))
                            {
                                context.LoadConfiguration(folder);
                                StaticContainer.Get<GlobalConfiguration>()
                                    .With(GlobalConfiguration.Configuration, c =>
                                    {
                                        c.AddDirectoryIfExists(dir, true);
                                    });
                            }


                        }
                    
                    }
                }
                else
                    Trace.TraceError("no configuration is downloaded because the configuration has no key : 'Bb.Loaders.ConfigLoaderInitializer' like 'url=https://github.com/Configurations/AdapterTest.git;user=gael;email=gael@gmail.com;branch=main;folder=Configs'");

            }


        }


        private const string _user = "user";
        private const string _email = "email";
        private const string _pwd = "pwd";
        private const string _branch = "branch";
        private const string _folder = "folder";

        /// <summary>
        /// Gets or sets the application configuration.
        /// </summary>
        /// <value>The <see cref="IConfiguration"/> instance representing the application configuration.</value>
        /// <remarks>
        /// This property is injected by the IoC container and provides access to the application's configuration settings.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var loader = new ConfigurationLoader();
        /// var config = loader.Configuration;
        /// Console.WriteLine($"Configuration: {config}");
        /// </code>
        /// </example>
        [InjectByIoc]
        public IConfiguration Configuration { get; set; }

        /// <summary>
        /// Gets or sets the configuration path dictionary used for Git repository settings.
        /// </summary>
        /// <value>A dictionary containing configuration keys and values for the Git repository.</value>
        /// <remarks>
        /// This property is injected by the IoC container and contains keys such as "url", "user", "email", "branch", and "folder" for configuring the Git repository.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var loader = new ConfigurationLoader();
        /// var configPath = loader.ConfigurationPath;
        /// Console.WriteLine($"Git URL: {configPath["url"]}");
        /// </code>
        /// </example>
        [InjectValueByIoc("Bb.Loaders.ConfigLoaderInitializer", false)]
        public Dictionary<string, string> ConfigurationPath { get; set; }

    }




}
