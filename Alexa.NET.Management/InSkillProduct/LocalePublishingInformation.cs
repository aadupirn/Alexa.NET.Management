﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.InSkillProduct
{
    public class LocalePublishingInformation
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("smallIconUri")]
        public string SmallIcon { get; set; }

        [JsonProperty("largeIconUri")]
        public string LargeIcon { get; set; }

        [JsonProperty("examplePhrases")]
        public List<string> ExamplePhrases { get; set; } = new List<string>();

        [JsonProperty("keywords")]
        public List<string> Keywords { get; set; } = new List<string>();

        [JsonProperty("customProductPrompts")]
        public CustomProductPrompts CustomProductPrompts { get; set; }
    }
}
