using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class ChampionshipMatch
    {
        [JsonProperty("match_id")]
        public string MatchId{ get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("game")]
        public string Game { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("competition_id")]
        public string CompetitionId { get; set; }

        [JsonProperty("competition_type")]
        public string CompetitionType { get; set; }

        [JsonProperty("competition_name")]   
        public string CompetitionName { get; set; }

        [JsonProperty("organizer_id")]
        public string OrganizerId { get; set; }

        [JsonProperty("teams")]
        public SimpleChampionshipTeams Teams { get; set; }
    }
}