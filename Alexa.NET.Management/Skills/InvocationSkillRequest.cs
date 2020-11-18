using VoicifyAlexa.NET.Request;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Skills
{
    public class InvocationSkillRequest
    {
        [JsonProperty("body")]
        public SkillRequest Body { get; set; }
    }
}