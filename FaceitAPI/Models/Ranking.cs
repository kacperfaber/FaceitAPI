using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class Ranking
    {
        [JsonProperty("current_streak")]
        public int? CurrentStreak { get; set; }

        [JsonProperty("draw")]
        public int? Draw { get; set; }

        [JsonProperty("lost")]
        public int? Lost { get; set; }

        [JsonProperty("played")]
        public int? Played { get; set; }

        [JsonProperty("player")]
        public Member Player { get; set; } 

        [JsonProperty("points")]
        public int? Points { get; set; }

        [JsonProperty("position")]
        public int? Position { get; set; }

        [JsonProperty("win_rate")]
        public int? WinRate { get; set; }

        [JsonProperty("won")]
        public int? Won { get; set; }
    }
}
