using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Manifest
{
    public class Permission
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}