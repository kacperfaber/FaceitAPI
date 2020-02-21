using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class SimpleHub
    {
        [JsonProperty("competition_id")]
        public string CompetitionId { get; set; }

        [JsonProperty("competition_type")]
        public string CompetitionType { get; set; }

        [JsonProperty("game")]
        public string Game { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("number_of_members")]
        public int? NumberOfMembers { get; set; }

        [JsonProperty("organizer_id")]
        public string OrganizerId { get; set; }

        [JsonProperty("organizer_name")]
        public string OrganizerName { get; set; }

        [JsonProperty("organizer_type")]
        public string OrganizerType { get; set; }

        [JsonProperty("players_checkedin")]
        public int? PlayersCheckedIn { get; set; }

        [JsonProperty("players_joined")]
        public int? PlayersJoined { get; set; }

        [JsonProperty("prize_type")]
        public string PrizeType { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("slots")]
        public int? Slots { get; set; }

        [JsonProperty("started_at")]
        public int? StartedAt { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("total_prize")]
        public string TotalPrize { get; set; }
    }
}