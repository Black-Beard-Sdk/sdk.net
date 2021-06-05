using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace Bb.Sdk.Net.Mails.Configurations
{


    public class SecureConverter : JsonConverter
    {

        public SecureConverter()
        {
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
                writer.WriteNull();

            else
            {
                var data = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(value.ToString()));
                writer.WriteValue(data);
            }

        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.Value == null)
                return null;

            var data = Convert.FromBase64String(reader.Value.ToString());
            var result = System.Text.Encoding.UTF8.GetString(data);
            return result;
        }

        public override bool CanRead { get { return true; } }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }

    }


}
