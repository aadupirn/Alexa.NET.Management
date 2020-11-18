﻿using VoicifyAlexa.NET.Management.Skills;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.InteractionModel
{
    public class SkillModelVersion
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("interactionModel")]
        public SkillInteraction InteractionModel { get; set; }
    }
}
