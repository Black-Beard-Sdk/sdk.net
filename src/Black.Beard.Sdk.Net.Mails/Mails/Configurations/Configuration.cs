using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;

namespace Bb.Sdk.Net.Mails.Configurations
{
    public class Configuration
    {

        public Configuration()
        {
            this.SmtpProfiles = new List<SmtpProfile>();
        }

        public static Configuration Instance
        {
            get
            {

                if (_instance == null)
                    InitializeConfiguration("config.json");

                return _instance;
            }
        }

        public List<SmtpProfile> SmtpProfiles { get; }

        public CultureEnum DefaultCulture { get; set; } = CultureEnum.Invariant_Language_Invariant_Country;

        public static void InitializeConfiguration(string filename)
        {

            var file = new FileInfo(filename);

            file.Refresh();

            lock (_lock)
                if (_instance == null)
                {
                    if (file.Exists)
                        _instance = JsonConvert.DeserializeObject<Configuration>(File.ReadAllText(file.FullName));
                }

        }

        public static void TryToInitialiseFromDirectoryWork()
        {
            var file = new FileInfo(Assembly.GetEntryAssembly().Location);
            file = new FileInfo(Path.Combine(file.Directory.FullName, "config.json"));
            file.Refresh();
            if (file.Exists)
                InitializeConfiguration(file.FullName);

            else
            {
                file = new FileInfo(Path.Combine(Environment.CurrentDirectory, "config.json"));
                file.Refresh();
                if (file.Exists)
                    InitializeConfiguration(file.FullName);
            }

        }

        public static bool Initialized { get => _instance != null; }




        private static Configuration _instance;
        private static object _lock = new object();

    }


}
