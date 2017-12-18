using Newtonsoft.Json;

namespace AstralNew.DAL.Models.Json.hh
{
    public class Employer
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
