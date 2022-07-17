using Newtonsoft.Json;

namespace ReadJSON.Domain
{
    public class Element
    {
        [JsonProperty("@name")]
        public string Name { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
