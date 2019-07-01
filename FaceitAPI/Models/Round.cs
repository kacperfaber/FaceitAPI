using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class Round
    {
        [JsonProperty("best_of")]
        public string BestOf { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("matches")]
        public int Matches { get; set; }

        [JsonProperty("round")]
        public int RoundI { get; set; }

        [JsonProperty("start_time")]
        public ulong StartTime { get; set; }

        [JsonProperty("starts_asap")]
        public bool?StartsAsap { get; set; }

        [JsonProperty("substitution_time")]
        public ulong? SubstitutionTime { get; set; }

        [JsonProperty("substitutions_allowed")]
        public bool? SubstitutionAllowed { get; set; }
    }
}