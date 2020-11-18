﻿using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Asr.Evaluations
{
    public class EvaluationError
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}