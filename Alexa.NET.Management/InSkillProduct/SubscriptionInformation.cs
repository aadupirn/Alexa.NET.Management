using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.InSkillProduct
{
    public class SubscriptionInformation
    {
        [JsonProperty("subscriptionPaymentFrequency")]
        public string SubscriptionPaymentFrequency { get; set; }

        [JsonProperty("subscriptionTrialPeriodDays")]
        public int TrialPeriodDays { get; set; }
    }
}