using Newtonsoft.Json;
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
            this.Profiles = new List<MailProfile>();
        }

        public static Configuration Instance
        {
            get
            {

                if (_instance == null)
                    InitializeConfiguration("mail.config.json");

                return _instance;
            }
        }

        
        public List<MailProfile> Profiles { get; }


        public static bool Initialized { get => _instance != null; }

        [JsonIgnore]
        public FileInfo Filename { get; private set; }

        public CultureEnum DefaultCulture { get; set; } = CultureEnum.Invariant_Language_Invariant_Country;

        #region In / out

        public static void InitializeConfiguration(string filename)
        {

            var file = new FileInfo(filename);

            file.Refresh();

            lock (_lock)
                if (_instance == null)
                {
                    if (file.Exists)
                    {
                        var converter = new ProfileConverter();
                        _instance = JsonConvert.DeserializeObject<Configuration>(File.ReadAllText(file.FullName), converter);
                        _instance.Filename = file;
                    }
                    else
                    {
                        _instance = new Configuration()
                        {
                            DefaultCulture = CultureEnum.Invariant_Language_Invariant_Country,
                        };
                        _instance.Filename = file;

                        _instance.Save();

                    }
                }

        }

        public void Save()
        {

            this.Filename.Refresh();
            bool saved = false;
            bool ok = false;
            string fileBack = this.Filename.FullName + ".back";


            if (this.Filename.Exists)
            {
                var b = new FileInfo(Filename.FullName);
                b.Refresh();
                b.MoveTo(fileBack);
                saved = true;
            }

            try
            {
                File.WriteAllText(this.Filename.FullName, JsonConvert.SerializeObject(_instance, Formatting.Indented));
                ok = true;
            }
            finally
            {

                if (saved)
                {
                    if (ok)
                        File.Delete(fileBack);
                    else
                    {
                        var b = new FileInfo(fileBack);
                        b.Refresh();
                        b.MoveTo(this.Filename.FullName);
                    }

                }

            }



        }

        #endregion In / out


        private static Configuration _instance;
        private static object _lock = new object();

    }


}
