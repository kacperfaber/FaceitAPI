using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class Settings
    {
        [JsonProperty("language")]
        public string Language { get; set; }
    }
}