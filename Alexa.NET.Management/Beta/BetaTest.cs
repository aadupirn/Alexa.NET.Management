﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Beta
{
    public class BetaTest
    {
        [JsonProperty("expiryDate")]
        public DateTime ExpiryDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("feedbackEmail")]
        public string FeedbackEmail { get; set; }

        [JsonProperty("invitationUrl")]
        public Uri InvitationUrl { get; set; }

        [JsonProperty("invitesRemaining")]
        public int InvitesRemaining { get; set; }
    }
}
