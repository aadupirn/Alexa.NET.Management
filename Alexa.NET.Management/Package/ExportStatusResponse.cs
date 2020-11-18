﻿using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Package
{
    public class ExportStatusResponse
    {
        [JsonProperty("status")]
        public ExportStatus Status { get; set; }

        [JsonProperty("skill")]
        public ExportMetadata Skill { get; set; }
    }
}
