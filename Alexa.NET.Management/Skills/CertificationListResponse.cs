﻿using System;
using System.Collections.Generic;
using System.Text;
using VoicifyAlexa.NET.Management.InSkillProduct;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Skills
{
    public class CertificationListResponse
    {
        [JsonProperty("_links")]
        public Dictionary<string, ApiLink> Links { get; set; }

        [JsonProperty("isTruncated")]
        public bool IsTruncated { get; set; }

        [JsonProperty("nextToken")]
        public string NextToken { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("items")]
        public CertificationSummary[] Items { get; set; }
    }
}
