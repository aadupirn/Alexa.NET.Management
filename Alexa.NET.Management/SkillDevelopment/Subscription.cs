﻿using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.SkillDevelopment
{
    public class Subscription:SubscriptionUpdate
    {
        [JsonProperty("vendorId")]
        public string VendorId { get; set; }

        [JsonProperty("subscriberId")]
        public string SubscriberId { get; set; }
    }
}
