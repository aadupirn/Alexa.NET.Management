using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.SlotType
{
    public class Version
    {
        [JsonProperty("slotType")]
        public VersionSlotType SlotType { get; set; }
    }
}
