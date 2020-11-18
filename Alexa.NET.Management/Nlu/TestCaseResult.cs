﻿using VoicifyAlexa.NET.Request;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Nlu.Evaluation
{
    public class TestCaseResult
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("intent")]
        public Intent Intent { get; set; }
    }
}