﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Asr.AnnotationSet
{
    public class CreateAnnotationSetRequest
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
