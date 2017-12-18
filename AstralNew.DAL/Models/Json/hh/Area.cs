using Newtonsoft.Json;

namespace AstralNew.DAL.Models.Json.hh
{
    public class Area
    {
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
