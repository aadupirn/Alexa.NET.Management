﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management
{
    public class PaginationContext
    {
        [JsonProperty("nextToken",NullValueHandling = NullValueHandling.Ignore)]
        public string NextToken { get; set; }
    }
}
