using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.AccountLinking
{
    public class AccountLinkInformation
    {
        [JsonProperty("accountLinkingResponse")]
        public AccountLinkData Response { get; set; }
    }
}