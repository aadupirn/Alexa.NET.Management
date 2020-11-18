﻿using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Nlu
{
    public class EvaluationSource
    {
        public EvaluationSource() { }

        public EvaluationSource(string annotationId)
        {
            AnnotationId = annotationId;
        }

        [JsonProperty("annotationId")]
        public string AnnotationId { get; set; }
    }
}