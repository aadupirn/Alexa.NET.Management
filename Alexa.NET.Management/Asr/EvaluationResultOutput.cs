using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Asr.Evaluations
{
    public class EvaluationResultOutput
    {
        [JsonProperty("transcription")]
        public string Transcription { get; set; }
    }
}