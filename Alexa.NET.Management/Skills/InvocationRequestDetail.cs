using VoicifyAlexa.NET.Request;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Skills
{
    public class InvocationRequestDetail
    {
        [JsonProperty("endpoint")]
        public string Endpoint { get; set; }

        [JsonProperty("body")]
        public SkillRequest Body { get; set; }
    }
}