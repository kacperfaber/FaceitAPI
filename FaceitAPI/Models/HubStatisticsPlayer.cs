using System.Collections.Generic;
using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class HubStatisticsPlayer
    {
        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("player_id")]
        public string PlayerId { get; set; }

        [JsonProperty("stats")]
        public Dictionary<string, object> Stats { get; set; }
    }
}