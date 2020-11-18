using System;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Api
{
    public class ExtensionUri
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }
    }
}