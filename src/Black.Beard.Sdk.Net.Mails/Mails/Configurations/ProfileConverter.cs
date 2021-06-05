using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace Bb.Sdk.Net.Mails.Configurations
{

    public class ProfileConverter : JsonConverter
    {

        public ProfileConverter()
        {
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jObject = JObject.Load(reader);
            var type = jObject[nameof(MailProfile.Type)].Value<string>();
            var profile = MailProfile.Get(type);
            JsonConvert.PopulateObject(jObject.ToString(), profile);
            return profile;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var obj = JToken.FromObject(value);
            obj.WriteTo(writer);
        }


        public override bool CanRead { get { return true; } }

        public override bool CanConvert(Type objectType)
        {
            return typeof(MailProfile).IsAssignableFrom(objectType);
        }

    }


}
