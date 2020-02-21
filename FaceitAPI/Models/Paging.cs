using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    /// <summary>
    ///     You can use this in foreach
    ///     np. foreach (var item in
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Paging<T>
    {
        [JsonProperty("start")]
        public int? Start { get; set; }

        [JsonProperty("end")]
        public int? End { get; set; }

        [JsonProperty("items")]
        public T[] Items { get; set; }
    }
}