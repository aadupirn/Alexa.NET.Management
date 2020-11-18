using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace VoicifyAlexa.NET.Management.Skills
{
    public class SimulationResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status"), JsonConverter(typeof(StringEnumConverter))]
        public InvocationStatus Status { get; set; }

        [JsonProperty("result")]
        public SimulationResult Result { get; set; }
    }
}