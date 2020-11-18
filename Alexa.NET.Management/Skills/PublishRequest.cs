using System;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Skills
{
    public class PublishRequest
    {
        [JsonProperty("publishesAt")]
        public DateTime PublishesAt { get; set; }
    }
}
