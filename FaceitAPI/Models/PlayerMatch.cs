using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class PlayerMatch
    {
        [JsonProperty("competition_id")]
        public string CompetitionId { get; set; }

        [JsonProperty("competition_name")]
        public string CompetitionName { get; set; }

        [JsonProperty("competition_type")]
        public string CompetitionType { get; set; }

        [JsonProperty("faceit_url")]
        public string FaceitUrl { get; set; }

        [JsonProperty("finished_at")]
        public ulong FinishedAt { get; set; }

        [JsonProperty("game_id")]
        public string GameId { get; set; }

        [JsonProperty("game_mode")]
        public string GameMode { get; set; }

        [JsonProperty("match_id")]
        public string MatchId { get; set; }

        [JsonProperty("match_type")]
        public string MatchType { get; set; }

        [JsonProperty("max_players")]
        public int? MaxPlayers { get; set; }

        [JsonProperty("organizer_id")]
        public string OrganizerId { get; set; }

        [JsonProperty("playing_players")]
        public string[] PlayingPlayers { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("results")]
        public MatchResults Results { get; set; }

        [JsonProperty("started_at")]
        public ulong? StartedAt { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("teams")]
        public Dictionary<string, object> Teams { get; set; }

        [JsonProperty("team_size")]
        public int? TeamSize { get; set; }
    }
}
