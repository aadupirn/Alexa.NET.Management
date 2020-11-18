using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Api
{
    public class CustomApiRegion
    {
        [JsonProperty("endpoint")]
        public Endpoint Endpoint { get; set; }
    }
}