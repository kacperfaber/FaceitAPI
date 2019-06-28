using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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

        [JsonProperty("teams")]
        private Dictionary<string, object> teams { get; set; }

        public MatchTeam[] Teams
        {
            get
            {
                var array = teams.Values.ToArray();
                List<MatchTeam> outarr = new List<MatchTeam>();

                foreach (var item in array)
                {
                    JObject a = (JObject) item;
                    outarr.Add(a.ToObject<MatchTeam>());
                }

                return outarr.ToArray();
            }

            set
            {
                Dictionary<string, object> dict = new Dictionary<string, object>();

                for (int x = 0; x < value.Length; x++)
                {
                    string name = "faction" + x;
                    dict.Add(name, value[x]);
                }
            }
        }

        [JsonProperty("voting")]
        public Voting Voting { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }
}
