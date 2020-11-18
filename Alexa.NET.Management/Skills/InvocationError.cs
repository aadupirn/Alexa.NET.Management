using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Skills
{
    public class InvocationError
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}