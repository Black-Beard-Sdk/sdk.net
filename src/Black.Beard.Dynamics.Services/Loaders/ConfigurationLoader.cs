using Bb.ComponentModel;
using Bb.ComponentModel.Attributes;
using Bb.Configuration;
using Bb.Configuration.Git;
using System.Diagnostics;
using System.Reflection;

namespace Bb.Loaders
{


    public static class AssemblyHelper
    {

        public static string GetDirectory(this Assembly assembly)
        {

            return assembly.Location.AsFile().Directory.FullName;

        }
    }

    /// <summary>
    /// Download configuration form git repository and load the configuration
    /// </summary>
    [ExposeClass(ConstantsCore.Initialization, ExposedType = typeof(IInjectBuilder<WebApplicationBuilder>), LifeCycle = IocScopeEnum.Transiant)]
    [Priority(1)]
    public class ConfigurationLoader : InjectBuilder<WebApplicationBuilder>
    {

        public ConfigurationLoader()
        {

        }

        public override object Execute(WebApplicationBuilder context)
        {

            context.LoadConfiguration(Environment.CurrentDirectory);
            context.LoadConfiguration(Assembly.GetEntryAssembly().GetDirectory());
            context.LoadConfiguration(Assembly.GetExecutingAssembly().GetDirectory());

            if (!InternetConnectivityChecker.IsConnected)
                return null;

            if (ConfigurationPath == null)
            {
                DefaultConfiguration();
                return null;
            }

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
                        ConfigurationFolder.AddDirectoryIfExists(dir);
                    }


                }
            }

            return null;

        }

        private void DefaultConfiguration()
        {

            var dir = Environment.CurrentDirectory.Combine("Config").CreateFolderIfNotExists();
            ConfigurationFolder.AddDirectoryIfExists(dir);

            Trace.TraceError("no configuration is downloaded because the configuration has no key : 'Bb.Loaders.ConfigLoaderInitializer' like 'url=https://github.com/Configurations/AdapterTest.git;user=gael;email=gael@gmail.com;branch=main;folder=Configs'");

        }

        public const string _user = "user";
        public const string _email = "email";
        public const string _pwd = "pwd";
        public const string _branch = "branch";
        public const string _folder = "folder";

        [InjectByIoc]
        public IConfiguration Configuration { get; set; }

        [InjectValueByIoc("Bb.Loaders.ConfigLoaderInitializer", false)]
        public Dictionary<string, string> ConfigurationPath { get; set; }

    }

    


}
