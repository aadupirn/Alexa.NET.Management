using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.ReferenceCatalogManagement
{
    [JsonConverter(typeof(UpdateJobTriggerConverter))]
    public interface IUpdateJobTrigger
    {
        public string Type { get; }
    }
}