﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.SkillDevelopment
{
    public class ListedSubscription:Subscription
    {
        [JsonProperty("subscriptionId")]
        public string SubscriptionId { get; set; }
    }
}
