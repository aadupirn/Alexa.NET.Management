﻿using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Alexa.NET.Management.Asr.AnnotationSet
{
    public class Annotation:AnnotationUpdate
    {

        [JsonProperty("audioAsset")]
        public AudioAsset AudioAsset { get; set; }
    }
}
