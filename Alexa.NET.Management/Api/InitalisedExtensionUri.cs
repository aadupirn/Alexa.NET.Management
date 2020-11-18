﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Api
{
    public class InitalisedExtensionUri : ExtensionUri
    {
        [JsonProperty("settings")]
        public Dictionary<string,string> Settings { get; set; }
    }
}