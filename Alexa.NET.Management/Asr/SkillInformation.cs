using VoicifyAlexa.NET.Management.Api;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace VoicifyAlexa.NET.Management.Asr.Evaluations
{
    public class SkillInformation
    {
        [JsonProperty("stage")]
        [JsonConverter(typeof(StringEnumConverter))]
        public SkillStage Stage { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }
    }
}