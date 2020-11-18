using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Api
{
    public class FlashBriefingLocale
    {
        [JsonProperty("customErrorMessage")]
        public string CustomErrorMessage { get; set; }

        [JsonProperty("feeds")]
        public FlashBriefingFeed[] Feeds { get; set; }
    }
}