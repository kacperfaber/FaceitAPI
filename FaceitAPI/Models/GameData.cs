using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class GameData
    {
        [JsonProperty("assets")]
        public Assets Assets { get; set; }

        [JsonProperty("game_id")]
        public string GameId { get; set; }

        [JsonProperty("long_label")]
        public string LongLabel { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("parent_game_id")]
        public string ParentGameId { get; set; }

        [JsonProperty("platforms")]
        public string[] Platforms { get; set; }

        [JsonProperty("regions")]
        public string[] Regions { get; set; }

        [JsonProperty("short_label")]
        public string ShortLabel { get; set; }
    }
}