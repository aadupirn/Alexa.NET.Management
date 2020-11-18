using System.Collections.Generic;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Skills
{
    public class SkillStatus
    {
        [JsonProperty("manifest")]
        public StatusManifest Manifest { get; set; }

        [JsonProperty("interactionModel")]
        public Dictionary<string,StatusManifest> InteractionModel { get; set; }
    }
}