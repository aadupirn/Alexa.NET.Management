﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Package
{
    public class CreateSkillPackageRequest
    {
        [JsonProperty("location")]
        public string Location { get; set; }
    }
}
