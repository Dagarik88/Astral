using Newtonsoft.Json;

namespace AstralNew.DAL.Models.Json.hh
{
    public class Snippet
    {
        [JsonProperty("requirement")]
        public string Requirement { get; set; }
        [JsonProperty("responsibility")]
        public string Responsibility { get; set; }
    }
}
