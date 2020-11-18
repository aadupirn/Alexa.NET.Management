using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.AccountLinking
{
    public class AccountLinkUpdate
    {
        [JsonProperty("accountLinkingRequest")]
        public AccountLinkData Data { get; set; }
    }
}