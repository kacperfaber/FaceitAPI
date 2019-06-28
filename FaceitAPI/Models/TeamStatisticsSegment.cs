using System.Collections.Generic;
using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class TeamStatisticsSegment
    {
        [JsonProperty("img_regular")]
        public string ImageRegular { get; set; }

        [JsonProperty("img_small")]
        public string ImageSmall { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("stats")]
        public Dictionary<string, string> Statistics { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}