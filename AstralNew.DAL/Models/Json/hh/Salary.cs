using Newtonsoft.Json;

namespace AstralNew.DAL.Models.Json.hh
{
    public class Salary
    {
        [JsonProperty("to")]
        public decimal? To { get; set; }
        [JsonProperty("from")]
        public decimal? From { get; set; }
        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
