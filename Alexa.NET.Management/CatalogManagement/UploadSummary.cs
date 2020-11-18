﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace VoicifyAlexa.NET.Management.CatalogManagement
{
    public class UploadSummary
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("catalogId")]
        public string CatalogId { get; set; }

        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public UploadStatus Status { get; set; }

        [JsonProperty("createdDate")]
        public DateTime CreatedDate { get; set; }

        [JsonProperty("lastUpdatedTime")]
        public DateTime LastUpdatedTime { get; set; }
    }
}
