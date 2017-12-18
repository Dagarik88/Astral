using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AstralNew.DAL.Models.Json.hh
{
    public class Item
    {
        [JsonProperty("salary")]
        public Salary Salary { get; set; }
        [JsonProperty("snippet")]
        public Snippet Snippet { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("area")]
        public Area Area { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("employer")]
        public Employer Employer { get; set; }
        [JsonProperty("published_at")]
        public DateTime PublishedAt { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
    }

}
