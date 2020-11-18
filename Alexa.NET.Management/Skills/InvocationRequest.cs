using VoicifyAlexa.NET.Management.Skills;
using VoicifyAlexa.NET.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace VoicifyAlexa.NET.Management
{
    public class InvocationRequest
    {
        public InvocationRequest() { }

        public InvocationRequest(InvocationEndpoint endpoint, SkillRequest request)
        {
            Endpoint = endpoint;
            Request = new InvocationSkillRequest{Body = request};
        }

        [JsonProperty("endpoint")]
        [JsonConverter(typeof(StringEnumConverter))]
        public InvocationEndpoint Endpoint { get; set; }

        [JsonProperty("skillRequest")]
        public InvocationSkillRequest Request { get; set; }
    }
}