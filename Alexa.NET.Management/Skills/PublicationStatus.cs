using System.Runtime.Serialization;

namespace VoicifyAlexa.NET.Management.Skills
{
    public enum PublicationStatus
    {
        [EnumMember(Value="DEVELOPMENT")]
        Development,
        [EnumMember(Value = "CERTIFICATION")]
        Certification,
        [EnumMember(Value = "PUBLISHED")]
        Published,
        [EnumMember(Value = "SUPPRESSED")]
        Suppressed,
        [EnumMember(Value = "PULLED")]
        Pulled,
        [EnumMember(Value = "HIDDEN")]
        Hidden,
        [EnumMember(Value = "REMOVED")]
        Removed
    }
}