﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.InteractionModel
{
    public class InteractionModelVersionsResponse
    {
        [JsonProperty("_links")]
        public Dictionary<string, ApiLink> Links { get; set; }

        [JsonProperty("nextToken")]
        public string NextToken { get; set; }

        [JsonProperty("isTruncated")]
        public bool IsTruncated { get; set; }

        [JsonProperty("skillModelVersions")]
        public SkillModelVersionSummary[] SkillModelVersionsSummary { get; set; }
    }
}
