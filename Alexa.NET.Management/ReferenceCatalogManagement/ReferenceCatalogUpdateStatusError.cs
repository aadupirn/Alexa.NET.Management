using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.ReferenceCatalogManagement
{
    public class ReferenceCatalogUpdateStatusError
    {
        [JsonProperty("code",NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        [JsonProperty("message",NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }
    }
}