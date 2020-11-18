using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.ReferenceCatalogManagement
{
    [JsonConverter(typeof(UpdateJobConverter))]
    public interface IUpdateJobDefinition
    {
        string Type { get; }
    }
}