using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Manifest
{
    public class PrivacyAndCompliantLocale
    {
        [JsonProperty("privacyPolicyUrl")]
        public string PrivacyPolicyUrl { get; set; }

        [JsonProperty("termsOfUseUrl")]
        public string TermsOfUseUrl { get; set; }
    }
}