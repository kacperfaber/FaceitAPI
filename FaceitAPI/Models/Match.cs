using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class Match
    {
        [JsonProperty("best_of")]
        public int BestOf { get; set; }

        [JsonProperty("broadcast_start_time")]
        public ulong BroadcastStartTime { get; set; }

        [JsonProperty("calculate_elo")]
        public bool CalculateElo { get; set; }

        [JsonProperty("chat_room_id")]
        public string ChatRoomId { get; set; }

        [JsonProperty("competition_id")]
        public string CompetitionId { get; set; }

        [JsonProperty("competition_name")]
        public string CompetitionName { get; set; }

        [JsonProperty("competition_type")]
        public string CompetitionType { get; set; }

        [JsonProperty("configured_at")]
        public ulong ConfiguredAt { get; set; }

        [JsonProperty("started_at")]
        public ulong StartedAt { get; set; }

        [JsonProperty("demo_url")]
        public string[] DemoUrl { get; set; }

        [JsonProperty("faceit_url")]
        public string FaceitUrl { get; set; }

        [JsonProperty("finished_at")]
        public ulong FinishedAt { get; set; }

        [JsonProperty("game")]
        public string Game { get; set; }

        [JsonProperty("group")]
        public int Group { get; set; }

        [JsonProperty("match_id")]
        public string MatchId { get; set; }

        [JsonProperty("organizer_id")]
        public string OrganizerId { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("results")]
        public MatchResults MatchResults { get; set; }

        [JsonProperty("round")]
        public int Round { get; set; }

        [JsonProperty("scheduled_at")]
        public ulong ScheduledAt { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [Obsolete("IN PUBG TEAMS IS MORE THAN 2. It will changed to Dict <string, Team>")]
        [JsonProperty("teams")]
        public Teams Teams { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }
}
