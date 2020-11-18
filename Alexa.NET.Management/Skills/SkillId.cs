using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Skills
{
    public class SkillId
    {
        [JsonProperty("skillId")]
        public string Id { get; set; }
    }
}
