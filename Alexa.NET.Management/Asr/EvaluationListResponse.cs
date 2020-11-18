﻿using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Asr.Evaluations
{
    public class EvaluationListResponse
    {
        [JsonProperty("paginationContext",NullValueHandling = NullValueHandling.Ignore)]
        public PaginationContext PaginationContext { get; set; }

        [JsonProperty("evaluations")]
        public EvaluationStatus[] Evaluations { get; set; }
    }
}