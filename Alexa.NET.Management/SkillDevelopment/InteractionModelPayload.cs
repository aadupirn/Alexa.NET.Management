using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.SkillDevelopment
{
    public class InteractionModelPayload:SkillDevelopmentEventPayload
    {
        [JsonProperty("interactionModel")]
        public InteractionModelDetail InteractionModel { get; set; }
    }
}