using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class RankingPaging<T> : Paging<T>
    {
        [JsonProperty("position")]
        public int? Position { get; set; }
    }
}