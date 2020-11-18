using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.SkillDevelopment
{
    public class InteractionModelDetail
    {
        [JsonProperty("skillId")]
        public string SkillId { get; set; }

        [JsonProperty("vendorId")]
        public string VendorId { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }
    }
}