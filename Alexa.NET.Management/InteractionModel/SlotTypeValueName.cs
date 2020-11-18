﻿using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.InteractionModel
{
    public class SlotTypeValueName
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("synonyms", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Synonyms { get; set; }
    }
}