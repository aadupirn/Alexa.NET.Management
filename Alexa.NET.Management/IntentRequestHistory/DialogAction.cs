﻿using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.IntentRequestHistory
{
    public class DialogAction
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}