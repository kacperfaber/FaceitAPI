using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class MatchTeam
    {
        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("faction_id")]
        public string FactionId { get; set; }

        [JsonProperty("leader")]
        public string Leader { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("roster")]
        public Roster[] Roster { get; set; }

        [JsonProperty("roster_v1")]
        public object RosterV1 { get; set; }

        [JsonProperty("substituted")]
        public bool? Substituted { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}