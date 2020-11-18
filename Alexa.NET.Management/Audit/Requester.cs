using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Audit
{
    public class Requester
    {
        public Requester() { }

        public Requester(string userId)
        {
            UserId = userId;
        }

        [JsonProperty("userId")]
        public string UserId { get; set; }
    }
}