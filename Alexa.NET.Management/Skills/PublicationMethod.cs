using System.Runtime.Serialization;

namespace VoicifyAlexa.NET.Management.Skills
{
    public enum PublicationMethod
    {
        [EnumMember(Value="AUTO_PUBLISHING")]
        Automatic,
        [EnumMember(Value="MANUAL_PUBLISHING")]
        Manual
    }
}