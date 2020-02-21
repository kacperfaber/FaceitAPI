using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class PlayerMatchesPaging<T> : Paging<T>
    {
        [JsonProperty("from")]
        public ulong? From { get; set; }

        [JsonProperty("to")]
        public ulong? To { get; set; }
    }
}