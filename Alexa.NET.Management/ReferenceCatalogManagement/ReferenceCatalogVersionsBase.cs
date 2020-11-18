using System.Collections.Generic;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.ReferenceCatalogManagement
{
    public class ReferenceCatalogVersionBase
    {
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("creationTime")]
        public string CreationTime { get; set; }
    }
}