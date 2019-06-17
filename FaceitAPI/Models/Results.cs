using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class Results
    {
        [JsonProperty("winner")]
        public string Winner { get; set; }
    }
}