using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class SimpleTournamentTeam
    {
        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("skill_level")]
        public int? SkillLevel { get; set; }

        [JsonProperty("subs_done")]
        public int SubsDone { get; set; }

        [JsonProperty("team_id")]
        public string TeamId { get; set; }

        [JsonProperty("team_leader")]
        public string TeamLeader { get; set; }

        [JsonProperty("team_type")]
        public string TeamType { get; set; }
    }
}