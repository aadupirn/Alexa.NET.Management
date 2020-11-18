using System;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Asr.AnnotationSet
{
    public class CreateAnnotationSetResponse
    {
        public string Id { get; set; }
        public Uri Location { get; set; }
    }
}