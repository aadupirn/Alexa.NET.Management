using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace VoicifyAlexa.NET.Management.Internals
{
    public class BetaTestRequest
    {
        [JsonProperty("feedbackEmail")]
        public string FeedbackEmail { get; set; }
    }
}
