﻿using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.InSkillProduct
{
    public class CustomProductPrompts
    {
        [JsonProperty("purchasePromptDescription")]
        public string PurchasePromptDescription { get; set; }

        [JsonProperty("boughtCardDescription")]
        public string BoughtCardDescription { get; set; }
    }
}