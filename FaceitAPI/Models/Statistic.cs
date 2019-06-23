using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    ///<summary>Without objects Lifetime and Segments.</summary>
    public class Statistic
    {
        [JsonProperty("game_id")]
        public string GameId { get; set; }

        [JsonProperty("player_id")]
        public string PlayerId { get; set; }
    }
}