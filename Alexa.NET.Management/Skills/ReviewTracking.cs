﻿using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Skills
{
    public class ReviewTracking:ReviewTrackingSummary
    {
        [JsonProperty("estimationUpdates")]
        public EstimationUpdate[] EstimationUpdates { get; set; }
    }
}