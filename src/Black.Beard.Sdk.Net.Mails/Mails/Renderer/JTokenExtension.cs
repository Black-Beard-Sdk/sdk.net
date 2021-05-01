using RazorEngine.Templating; // For extension methods.
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Bb.Sdk.Net.Mails.Renderer
{
    public static class JTokenExtension
    {

        public static object ConvertToDynamicViewBag(this JToken self)
        {

            if (self is JObject o)
            {

                var dic = new Dictionary<string, object>();

                foreach (var property in o.Properties())
                {
                    object value = property.Value.ConvertToDynamicViewBag();
                    dic.Add(property.Name, value);
                }

                return new DynamicViewBag(dic);

            }
            if (self is JValue v)
                return v.Value;
            
            if (self is JArray a)
            {
                List<object> _array = new List<object>(a.Count);
                foreach (JToken item in a)
                {
                    if (item is JObject)
                        _array.Add(item.ConvertToDynamicViewBag());
                }
                return _array;
            }

            else
            {

            }

            return null;

        }

    }


}
