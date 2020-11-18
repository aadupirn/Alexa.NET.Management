﻿using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.SlotType
{
    public class VersionDefinition
    {
        public VersionDefinition() { }

        public VersionDefinition(ValueSupplier supplier)
        {
            ValueSupplier = supplier;
        }

        [JsonProperty("valueSupplier")]
        public ValueSupplier ValueSupplier { get; set; }
    }
}