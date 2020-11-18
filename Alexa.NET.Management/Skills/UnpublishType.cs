using System.Runtime.Serialization;

namespace VoicifyAlexa.NET.Management.Skills
{
    public enum UnpublishType
    {
        [EnumMember(Value="HIDE")]
        Hide,
        [EnumMember(Value="REMOVE")]
        Remove
    }
}