using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class HubStatistics
    {
        [JsonProperty("game_id")]
        public string GameId { get; set; }

        [JsonProperty("players")]
        public HubStatisticsPlayer[] Players { get; set; }
    }
}