﻿using Newtonsoft.Json;

namespace Alexa.NET.Management.ReferenceCatalogManagement
{
    public class ReferenceCatalogCreateVersionRequest
    {
        [JsonProperty("source")]
        public ReferenceCatalogCreateVersionRequestSource Source { get; set; }

        [JsonProperty("description",NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }
    }
}