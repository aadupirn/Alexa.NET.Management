using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.ReferenceCatalogManagement
{
    public class UpdateJobExecutionErrorDetails
    {
        [JsonProperty("executionMetadata",NullValueHandling = NullValueHandling.Ignore)]
        public UpdateJobExecutionMetadata[] ExecutionMetadata { get; set; }
    }
}