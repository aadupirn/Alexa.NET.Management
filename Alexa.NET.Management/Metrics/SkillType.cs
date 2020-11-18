using System.Runtime.Serialization;

namespace VoicifyAlexa.NET.Management.Metrics
{
    public enum SkillType
    {
        [EnumMember(Value="custom")]
        Custom,
        [EnumMember(Value = "smartHome")]
        SmartHome,
        [EnumMember(Value = "flashBriefing")]
        FlashBriefing
    }
}