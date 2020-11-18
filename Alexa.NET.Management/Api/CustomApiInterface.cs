using VoicifyAlexa.NET.Management.Internals;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Api
{
    [JsonConverter(typeof(CustomApiInterfaceConverter))]
    public abstract class CustomApiInterface
    {
        [JsonProperty("type")]
        public abstract string Type { get; }
    }
}