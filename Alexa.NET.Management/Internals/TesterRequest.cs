using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Internals
{
    public class TesterRequest
    {
        [JsonProperty("testers")]
        public TesterEmail[] Testers { get; set; }
    }
}