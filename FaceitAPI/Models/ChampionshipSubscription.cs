using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class ChampionshipSubscription
    {
        [JsonProperty("coach")]
        public string Coach { get; set; }

        [JsonProperty("coleader")]
        public string Coleader { get; set; }

        [JsonProperty("leader")]
        public string Leader { get; set; }

        [JsonProperty("group")]
        public int? Group { get; set; }

        [JsonProperty("roster")]
        public string[] Roster { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("substitutes")]
        public string[] Substitutes { get; set; }

        [JsonProperty("team")]
        public ChampionshipTeam Team { get; set; }
    }
}