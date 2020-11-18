﻿using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Package
{
    public class ImportStatusSkill
    {
        [JsonProperty("skillId")]
        public string SkillId { get; set; }

        [JsonProperty("eTag")]
        public string ETag { get; set; }

        [JsonProperty("resources")]
        public ImportStatusResource[] Resources { get; set; }
    }
}