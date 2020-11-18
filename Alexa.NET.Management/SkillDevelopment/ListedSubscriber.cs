using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.SkillDevelopment
{
    public class ListedSubscriber : SubscriberUpdate
    {
        [JsonProperty("subscriberId")]
        public string SubscriptionId { get; set; }
    }
}