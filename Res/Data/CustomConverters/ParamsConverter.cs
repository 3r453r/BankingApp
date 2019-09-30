using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PP.EF.Data.CustomConverters
{
    public class ParamsConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Params);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return new Params(serializer.Deserialize<Dictionary<string, object>>(reader));
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, (value as Params).ToDictionary());
        }
    }
}
