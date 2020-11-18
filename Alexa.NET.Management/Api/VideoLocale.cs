using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Api
{
    public class VideoLocale
    {
        [JsonProperty("videoProviderTargetingNames")]
        public string[] VideoProviderTargetingNames { get; set; }
    }
}