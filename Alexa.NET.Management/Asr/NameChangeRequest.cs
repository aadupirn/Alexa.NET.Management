﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Asr.AnnotationSet
{
    public class NameChangeRequest
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
