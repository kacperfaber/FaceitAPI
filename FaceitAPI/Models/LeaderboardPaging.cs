using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class LeaderboardPaging<T> : Paging<T>
    {
        [JsonProperty("leaderboard")]
        public LeaderboardDetails Leaderboard { get; set; }
    }
}