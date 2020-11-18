using VoicifyAlexa.NET.Management.Vendors;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management
{
    public class VendorResponse
    {
        [JsonProperty("vendors")]
        public Vendor[] Vendors { get; set; }
    }
}