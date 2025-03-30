using System.Collections;


namespace Bb.Configuration
{

    public class ConfigurationLoader : IEnumerable<IGrouping<string, ConfigurationFile>>
    {

        static ConfigurationLoader()
        {

            _environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")
                ?? null;
        }

        public ConfigurationLoader(string pattern, Func<FileInfo, bool> filter = null)
        {

            if (string.IsNullOrEmpty(pattern))
                pattern = $"*.json";

            _filter = filter;
            _pattern = pattern;

            _files = new Dictionary<string, ConfigurationFile>();

        }

        private static List<ConfigurationFile> GetFiles(Func<FileInfo, bool> filter, DirectoryInfo item, string pattern)
        {

            List<ConfigurationFile> items = new List<ConfigurationFile>();
            item.Refresh();

            var files = item.GetFiles(pattern);
            foreach (var file in files)
                if (filter == null || filter(file))
                {
                    var a = new ConfigurationFile() { FileInfo = file, Name = ComputeName(file.Name), Environment = ComputeEnvironmentName(file.Name) };
                    if (a.Environment == _environmentName || a.Environment == null)
                        items.Add(a);
                }
            return items;

        }

        private static string ComputeName(string name)
        {
            var n = name.Split('.');
            return n[0];
        }

        private static string? ComputeEnvironmentName(string name)
        {
            var n = name.Split('.');
            if (n.Length > 2)
                return n[1];
            return null;
        }

        public IEnumerator<IGrouping<string, ConfigurationFile>> GetEnumerator()
        {
            var _i = _files.Values.GroupBy(c => c.Name).ToList();
            return _i.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            var _i = _files.Values.GroupBy(c => c.Name).ToList();
            return _i.GetEnumerator();
        }

        internal ConfigurationLoader AddFolders(params string[] paths)
        {

            if (paths == null)
                return this;

            foreach (var item1 in paths)
            {

                var contentRootPath = item1.AsDirectory();

                var f = GetFiles(_filter, contentRootPath, _pattern);

                foreach (var item in f)
                    if (!_files.ContainsKey(item.Name))
                        _files.Add(item.FileInfo.FullName, item);

            }

            return this;

        }

        private static string? _environmentName;
        private Dictionary<string, ConfigurationFile> _files;
        private readonly Func<FileInfo, bool> _filter;
        private readonly string _pattern;

    }


    public struct ConfigurationFile
    {
        public string Name;
        public FileInfo FileInfo;
        public string? Environment;
    }


}
