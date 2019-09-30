using CdcSoftware.Pivotal.Engine;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP.EF.Data.CustomConverters
{
    public class IdConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Id);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return Id.Create(serializer.Deserialize<string>(reader));
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, (value as Id).ToString());
        }
    }
}
