using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.ReferenceCatalogManagement
{
    public class ReferencedResourceJobsCompleteTrigger : IUpdateJobTrigger
    {
        [JsonProperty("type")]
        public string Type => "ReferencedResourceJobsComplete";
    }
}