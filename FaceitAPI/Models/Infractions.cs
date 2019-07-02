using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class Infractions
    {
        [JsonProperty("last_infraction_date")]
        public string LastInfractionDate { get; set; }

        [JsonProperty("afk")]
        public int Afk { get; set; }

        [JsonProperty("Leaver")]
        public int Leaver { get; set; }

        [JsonProperty("qm_not_checkedin")]
        public int QmNotCheckedin { get; set; }

        [JsonProperty("qm_not_voted")]
        public int QmNotVoted { get; set; }
    }
}