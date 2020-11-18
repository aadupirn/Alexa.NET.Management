using VoicifyAlexa.NET.Management.Manifest;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace VoicifyAlexa.NET.Management.Skills
{
    public class SkillCreateRequest
    {
        [JsonProperty("manifest")]
        public SkillManifest Manifest { get; set; }

        [JsonProperty("vendorId")]
        public string VendorId { get; set; }
    }
}
