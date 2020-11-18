﻿using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.ReferenceCatalogManagement
{
    public class ReferenceCatalogCreateVersionRequest
    {
        [JsonProperty("source")]
        public ReferenceCatalogSource Source { get; set; }

        [JsonProperty("description",NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }
    }
}