using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class TournamentTeams
    {
        [JsonProperty("checked_in")]
        public SimpleTournamentTeam[] CheckedIn { get; set; }

        [JsonProperty("finished")]
        public SimpleTournamentTeam[] Finished { get; set; }

        [JsonProperty("joined")]
        public SimpleTournamentTeam[] Joined { get; set; }

        [JsonProperty("Started")]
        public SimpleTournamentTeam[] Started { get; set; }
    }
}