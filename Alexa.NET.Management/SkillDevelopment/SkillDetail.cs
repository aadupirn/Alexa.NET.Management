﻿using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.SkillDevelopment
{
    public class SkillDetail
    {
        [JsonProperty("skillId")]
        public string SkillId { get; set; }

        [JsonProperty("vendorId")]
        public string VendorId { get; set; }
    }
}