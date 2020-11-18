﻿using VoicifyAlexa.NET.Management.Api;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Validation
{
    public class ValidationResult
    {
        [JsonProperty("validations")]
        public Validation[] Validations { get; set; }

        [JsonProperty("error")]
        public ValidationError Error { get; set; }
    }
}