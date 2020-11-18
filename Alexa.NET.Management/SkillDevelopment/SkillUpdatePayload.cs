using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.SkillDevelopment
{
    public class SkillUpdatePayload : SkillDevelopmentEventPayload
    {
        [JsonProperty("skill")]
        public SkillDetail Skill { get; set; }
    }
}