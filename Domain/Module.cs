using Newtonsoft.Json;
using System.Collections.Generic;

namespace ReadJSON.Domain
{
    public class Module
    {
        [JsonProperty("@name")]
        public string Name { get; set; }
        [JsonProperty("subsystem")]
        public List<Subsystem> Subsystems { get; set; }
    }
}
