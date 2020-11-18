using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.SkillDevelopment
{
    public class SkillDevelopmentActor
    {
        [JsonProperty("customerId")]
        public string CustomerId { get; set; }
    }
}