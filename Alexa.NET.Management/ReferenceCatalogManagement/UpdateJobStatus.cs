using System.Runtime.Serialization;

namespace VoicifyAlexa.NET.Management.ReferenceCatalogManagement
{
    public enum UpdateJobStatus
    {
        [EnumMember(Value="ENABLED")]
        Enabled,
        [EnumMember(Value="DISABLED")]
        Disabled
    }
}