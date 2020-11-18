using System;
using System.Collections.Generic;
using System.Text;
using VoicifyAlexa.NET.Request;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Asr.AnnotationSet
{
    public class AnnotationSetResponse
    {
        [JsonProperty("paginationContext",NullValueHandling = NullValueHandling.Ignore)]
        public PaginationContext PaginationContext { get; set; }

        [JsonProperty("annotations",NullValueHandling = NullValueHandling.Ignore)]
        public Annotation[] Annotations { get; set; }
    }
}
