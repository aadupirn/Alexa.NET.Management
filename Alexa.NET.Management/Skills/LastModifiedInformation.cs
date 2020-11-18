using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace VoicifyAlexa.NET.Management.Skills
{
    public class LastModifiedInformation
    {
        [JsonProperty("status"), JsonConverter(typeof(StringEnumConverter))]
        public SkillStatusState Status { get; set; }
    }
}