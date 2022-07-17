using Newtonsoft.Json;

namespace ReadJSON.Domain
{
    public class JSONCollection
    {
        [JsonProperty("DPCLSettings:Settings")]
        public GlobalSettings Settings { get; set; }
    }
}
