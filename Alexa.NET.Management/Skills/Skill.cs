using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Skills
{
    public class Skill
    {
        [JsonProperty("manifest")]
        public Manifest.SkillManifest Manifest { get; set; }
    }
}
