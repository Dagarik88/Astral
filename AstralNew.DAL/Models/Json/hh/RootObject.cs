using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AstralNew.DAL.Models.Json.hh
{
    public partial class RootObject
    {
        [JsonProperty("clusters")]
        public object Clusters { get; set; }
        [JsonProperty("items")]
        public List<Item> Items { get; set; }
        [JsonProperty("found")]
        public int Found { get; set; }
        [JsonProperty("per_page")]
        public int PerPage { get; set; }
        
        public RootObject()
        {
            Items = new List<Item>();
        }
    }
    public partial class RootObject
    {
        public static RootObject FromJson(string input) => JsonConvert.DeserializeObject<RootObject>(input, Convertor.SerializerSettings);
    }

    public class Convertor
    {
        public static readonly JsonSerializerSettings SerializerSettings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None
        };
    }
}
