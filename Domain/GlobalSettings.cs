using Newtonsoft.Json;

namespace ReadJSON.Domain
{
    public class GlobalSettings
    {
        [JsonProperty("@xmlns:SOAP-ENV")]
        public string XmlnsSOAPEnv { get; set; }
        [JsonProperty("@xmlns:SOAP-ENC")]
        public string XmlnsSOAPEnc { get; set; }
        [JsonProperty("@xmlns:xsi")]
        public string XmlnsXSI { get; set; }
        [JsonProperty("@xmlns:xsd")]
        public string XmlnsXSD { get; set; }
        [JsonProperty("@xmlns:DPCLEmboss")]
        public string XmlnsDPCLEmboss { get; set; }
        [JsonProperty("@xmlns:DPCLWheel")]
        public string XmlnsDPCLWheel { get; set; }
        [JsonProperty("@xmlns:DPCLMagStripe")]
        public string XmlnsDPCLMagStripe { get; set; }
        [JsonProperty("@xmlns:DPCLSensors")]
        public string XmlnsDPCLSensors { get; set; }
        [JsonProperty("@xmlns:DPCLSettings")]
        public string XmlnsDPCLSettings { get; set; }
        [JsonProperty("@xmlns:DPCLUpdate")]
        public string XmlnsDPCLUpdate { get; set; }
        [JsonProperty("@xmlns:DPCLNetworkAccessList")]
        public string XmlnsDPCLNetworkAccessList { get; set; }
        [JsonProperty("@xmlns:xop")]
        public string XmlnsXOP { get; set; }
        [JsonProperty("@xmlns:xmime5")]
        public string XmlnsXmime5 { get; set; }
        [JsonProperty("@xmlns:DPCL")]
        public string XmlnsDPCL { get; set; }
        [JsonProperty("@xmlns:DPCL2")]
        public string XmlnsDPCL2 { get; set; }
        [JsonProperty("@SOAP-ENV:encodingStyle")]
        public string XmlnsEncodingStyle { get; set; }
        [JsonProperty("module")]
        public Module Module { get; set; }
    }
}
