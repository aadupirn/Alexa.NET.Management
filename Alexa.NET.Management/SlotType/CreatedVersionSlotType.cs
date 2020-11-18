using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.SlotType
{
    public class CreatedVersionSlotType : VersionSlotType
    {
        [JsonProperty("version")]
        public string Version { get; set; }
    }
}