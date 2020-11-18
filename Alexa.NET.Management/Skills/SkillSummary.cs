﻿using System;
using System.Collections.Generic;
using System.Text;
using VoicifyAlexa.NET.Management.Api;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace VoicifyAlexa.NET.Management.Skills
{
    public class SkillSummary
    {
        [JsonProperty("lastUpdated")]
        public DateTime LastUpdated { get; set; }

        [JsonProperty("nameByLocale")]
        public Dictionary<string,string> NameByLocale { get; set; }

        [JsonProperty("stage"),JsonConverter(typeof(StringEnumConverter))]
        public SkillStage Stage { get; set; }

        [JsonProperty("apis")]
        public string[] Apis { get; set; }

        [JsonProperty("publicationStatus"),JsonConverter(typeof(StringEnumConverter))]
        public PublicationStatus Status { get; set; }

        [JsonProperty("skillId")]
        public string SkillId { get; set; }

        [JsonProperty("_links")]
        public Dictionary<string, ApiLink> Links { get; set; }
    }
}
