using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.SlotType
{
    public class ValueCatalog
    {
        [JsonProperty("catalogId")]
        public string CatalogId { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}