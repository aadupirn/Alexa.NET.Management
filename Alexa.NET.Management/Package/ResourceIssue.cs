using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Package
{
    public class ResourceIssue
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}