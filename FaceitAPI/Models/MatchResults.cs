using System.Collections.Generic;
using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class MatchResults
    {
        [JsonProperty("winner")]
        public string Winner { get; set; }

        [JsonProperty("score")]
        public Dictionary<string, int> Score { get; set; }
    }
}