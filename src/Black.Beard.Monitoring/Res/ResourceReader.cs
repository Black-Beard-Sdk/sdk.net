using System.Reflection;


namespace Bb.Res
{

    public static class ResourceReader
    {


        public static string ReadEmbeddedResource(this string resourceName)
        {
            return typeof(ResourceReader).Assembly.ReadEmbeddedResource(resourceName);
        }

        public static string ReadEmbeddedResource(this Assembly assembly, string resourceName)
        {
            using (var stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                {
                    var list = string.Join(";", assembly.GetManifestResourceNames());
                    throw new FileNotFoundException($"Resource '{resourceName}' not found. try ({list})", resourceName);
                }

                using (var reader = new StreamReader(stream))
                    return reader.ReadToEnd();

            }
        }



    }

}
