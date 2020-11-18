using System.Collections.Generic;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.SlotType
{
    public class LinkedSharedSlotType:SharedSlotType
    {
        [JsonProperty("_links")]
        public Dictionary<string, ApiLink> Links { get; set; }
    }
}