using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.ReferenceCatalogManagement
{
    public class LocaleCatalogResource : CatalogResource
    {
        [JsonProperty("locales",NullValueHandling = NullValueHandling.Ignore)]
        public string[] Locales  { get; set; }
    }
}