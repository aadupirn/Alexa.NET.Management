using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Vendors
{
    public class Vendor
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }
    }
}