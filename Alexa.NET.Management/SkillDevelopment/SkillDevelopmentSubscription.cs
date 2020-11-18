using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.SkillDevelopment
{
    public class SkillDevelopmentSubscription
    {
        [JsonProperty("subscriptionId")]
        public string SubscriptionId { get; set; }
    }
}