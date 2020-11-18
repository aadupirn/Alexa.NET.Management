﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Api
{
    public class FlashBriefingApi:IApi
    {
        [JsonProperty("locales")]
        public Dictionary<string,FlashBriefingLocale> Locales { get; set; }
    }
}