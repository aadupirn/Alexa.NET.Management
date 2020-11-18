using System.Runtime.Serialization;

namespace VoicifyAlexa.NET.Management.CatalogManagement
{
    public enum IngestionStepName
    {
        [EnumMember(Value = "UPLOAD")]
        Upload,
        [EnumMember(Value = "SCHEMA_VALIDATION")]
        SchemaValidation
    }
}