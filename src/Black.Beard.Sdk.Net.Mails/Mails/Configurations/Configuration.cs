using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Bb.Sdk.Net.Mails.Configurations
{
    public class Configuration
    {

        public Configuration()
        {
            this.SptmProfiles = new List<SmtpProfile>();
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

        public List<SmtpProfile> SptmProfiles { get; }

        public string DefaultCulture { get; set; } = CultureInfo.InvariantCulture.Name;

        public static void InitializeConfiguration(string filename)
        {

            var file = new FileInfo(filename);

            lock (_lock)
                if (_instance == null)
                {
                    InitializeConfiguration("config.json");
                    file.Refresh();

                    if (file.Exists)
                        _instance = JsonConvert.DeserializeObject<Configuration>(File.ReadAllText(file.FullName));

                }

            var schema = NJsonSchema.JsonSchema.FromType(typeof(Configuration));

            var _file = new FileInfo(Path.Combine(file.Directory.FullName, "configuration.schema.json"));
            if (_file.Exists)
                _file.Delete();

            File.WriteAllText(_file.FullName, schema.ToJson());

        }





        private static Configuration _instance;
        private static object _lock = new object();

    }


}
