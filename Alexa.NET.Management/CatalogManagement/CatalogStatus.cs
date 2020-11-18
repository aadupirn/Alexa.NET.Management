using System.Runtime.Serialization;

namespace VoicifyAlexa.NET.Management.CatalogManagement
{
    public enum CatalogStatus
    {
        [EnumMember(Value="PENDING")]
        Pending,
        [EnumMember(Value = "PROCESSING")]
        Processing,
        [EnumMember(Value = "FAILED")]
        Failed,
        [EnumMember(Value = "SUCCESS")]
        Success,
    }
}