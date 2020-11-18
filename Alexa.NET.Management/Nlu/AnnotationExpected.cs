using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Nlu.AnnotationSet
{
    public class AnnotationExpected
    {
        [JsonProperty("intent")]
        public AnnotationIntent Intent { get; set; }
    }
}