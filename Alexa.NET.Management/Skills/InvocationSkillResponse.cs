using VoicifyAlexa.NET.Response;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Skills
{
    public class InvocationSkillResponse
    {
        [JsonProperty("body")]
        public SkillResponse Response { get; set; }
    }
}