﻿using VoicifyAlexa.NET.Request;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.UtteranceProfiler
{
    public class UtteranceProfilerResponse
    {
        [JsonProperty("sessionEnded")]
        public bool SessionEnded { get; set; }

        [JsonProperty("selectedIntent")]
        public Intent SelectedIntent { get; set; }

        [JsonProperty("consideredIntents")]
        public Intent[] ConsideredIntents { get; set; }

        [JsonProperty("multiTurn")]
        public MultiTurn MultiTurn { get; set; }
    }
}
