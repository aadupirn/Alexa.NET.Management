using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Skills
{
    public class SkillInteractionContainer
    {
        [JsonProperty("interactionModel")]
        public SkillInteraction InteractionModel { get; set; }
    }
}