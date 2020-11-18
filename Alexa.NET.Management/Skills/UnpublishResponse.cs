using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Skills
{
    public class UnpublishResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}