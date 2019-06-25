using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class MatchStatistics
    {
        [JsonProperty("rounds")]
        public MatchRound[] Rounds { get; set; }
    }
}
