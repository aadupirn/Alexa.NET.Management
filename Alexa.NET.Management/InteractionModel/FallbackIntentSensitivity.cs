using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace VoicifyAlexa.NET.Management.InteractionModel
{
    public class FallbackIntentSensitivity
    {
        [JsonProperty("level",NullValueHandling = NullValueHandling.Ignore),JsonConverter(typeof(StringEnumConverter))]
        public FallbackIntentSensitivityLevel? Level { get; set; }
    }
}