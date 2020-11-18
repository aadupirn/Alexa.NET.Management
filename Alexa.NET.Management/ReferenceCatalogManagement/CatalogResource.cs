﻿using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.ReferenceCatalogManagement
{
    public class CatalogResource
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type",NullValueHandling = NullValueHandling.Ignore)]
        public CatalogResourceType Type { get; set; }
    }
}