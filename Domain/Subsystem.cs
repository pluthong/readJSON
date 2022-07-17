using Newtonsoft.Json;
using System.Collections.Generic;

namespace ReadJSON.Domain
{
    public class Subsystem
    {
        [JsonProperty("@name")]
        public string Name { get; set; }
        [JsonProperty("element")]
        public List<Element> Elements { get; set; }
    }
}
