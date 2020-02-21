using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class Voting
    {
        [JsonProperty("map")]
        public VotingMaps Maps { get; set; }

        [JsonProperty("voted_entity_types")]
        public string[] VotedEntityTypes { get; set; }
    }
}