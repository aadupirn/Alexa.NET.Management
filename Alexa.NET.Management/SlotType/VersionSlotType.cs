﻿using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.SlotType
{
    public class VersionSlotType
    {
        [JsonProperty("definition")]
        public VersionDefinition Definition { get; set; }

        [JsonProperty("description",NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }
    }
}