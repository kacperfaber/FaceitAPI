using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    /// <summary>
    /// You can use this in foreach
    /// np. foreach (var item in 
    /// </summary>
    /// <typeparam name="TYPE"></typeparam>
    public class Paging <TYPE>
    {
        [JsonProperty("start")]
        public int? Start { get; set; }

        [JsonProperty("end")]
        public int? End { get; set; }

        [JsonProperty("items")]
        public TYPE[] Items { get; set; }
    }
}