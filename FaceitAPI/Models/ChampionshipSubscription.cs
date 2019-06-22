using Newtonsoft.Json;

namespace FaceitAPI.Interfaces
{
    public class ChampionshipSubscription
    {
        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("items")]
        public ChampionshipSubscriptionItem[] Items { get; set; }
    }
}