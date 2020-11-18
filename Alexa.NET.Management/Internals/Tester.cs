using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Internals
{
    public class TesterEmail
    {
        [JsonProperty("emailId")]
        public string Email { get; set; }
    }
}