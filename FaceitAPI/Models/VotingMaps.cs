using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class VotingMaps
    {
        [JsonProperty("entities")]
        public Map[] Entities { get; set; }

        [JsonProperty("pick")]
        public string[] Pick { get; set; }
    }
}