using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Validation
{
    public class ValidationError
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}