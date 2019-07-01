using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class SimpleChampionship
    {
        [JsonProperty("competition_id")]
        public string CompetitionId { get; set; }

        [JsonProperty("competition_type")]
        public string CompetitionType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("game")]
        public string Game { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("organizer_id")]
        public string OrganizerId { get; set; }

        [JsonProperty("organizer_name")]
        public string OrganizerName { get; set; }

        [JsonProperty("organizer_type")]
        public string OrganizerType { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("started_at")]
        public ulong? StartedAt { get; set; }

        [JsonProperty("slots")]
        public int? Slots { get; set; }

        [JsonProperty("number_of_members")]
        public int? NumberOfMembers { get; set; }
    }
}
