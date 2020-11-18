using System;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Skills
{
    public class EstimationUpdate
    {
        [JsonProperty("originalEstimatedCompletionTimestamp")]
        public DateTime OriginalEstimatedCompletionTimestamp { get; set; }

        [JsonProperty("revisedEstimatedCompletionTimestamp")]
        public DateTime RevisedEstimatedCompletionTimestamp { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}