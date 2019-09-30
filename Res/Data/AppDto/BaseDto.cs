using Newtonsoft.Json;
using PP.EF.Data.CustomConverters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP.EF.Data.AppDto
{
    public abstract class BaseDto
    {
        public string Id { get; set; }
        public bool MockLog { get; set; }

        public BaseDtoSerialized Serialize()
        {
            return new BaseDtoSerialized
            {
                Data = JsonConvert.SerializeObject(this, GetDefaultSettings()),
                TypeName = GetType().FullName
            };
        }

        public virtual BaseDtoSerialized SerializeForLogging()
        {
            return Serialize();
        }

        //public async Task<BaseDtoSerialized> SerializeAsync()
        //{
        //    string data = await Task.Run(() => JsonConvert.SerializeObject(this, GetDefaultSettings()));
        //    return new BaseDtoSerialized
        //    {
        //        Data = data,
        //        TypeName = GetType().FullName
        //    };
        //}

        private JsonSerializerSettings GetDefaultSettings()
        {
            return new JsonSerializerSettings
            {
                Converters = new List<JsonConverter> { new ParamsConverter(), new IdConverter(), new DataTableConverter() }
                ,TypeNameHandling = TypeNameHandling.Objects
                ,Formatting = Formatting.None
            };
        }
    }

    public class BaseDtoSerialized
    {
        public string Data { get; set; }
        public string TypeName { get; set; }
        public object Deserialize()
        {
            return JsonConvert.DeserializeObject(Data, GetDtoType(), GetDefaultSettings());
        }
        //public async Task<object> DeserializeAsync()
        //{
        //    return await Task.Run(() => JsonConvert.DeserializeObject(Data, GetDtoType(), GetDefaultSettings()));
        //}
        public Type GetDtoType()
        {
            return GetType().Assembly.GetType(TypeName);
        }

        private JsonSerializerSettings GetDefaultSettings()
        {
            return new JsonSerializerSettings
            {
                Converters = new List<JsonConverter> { new ParamsConverter(), new IdConverter(), new DataTableConverter() }
                ,TypeNameHandling = TypeNameHandling.Objects
                ,Formatting = Formatting.None
            };
        }
    }
}
