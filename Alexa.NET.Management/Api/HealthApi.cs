using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Api
{
    public class HealthApi
    {
        [JsonProperty("endpoint")]
        public Endpoint Endpoint { get; set; }

        [JsonProperty("regions")]
        public Dictionary<string, CustomApiRegion> Regions { get; set; }
    }
}
