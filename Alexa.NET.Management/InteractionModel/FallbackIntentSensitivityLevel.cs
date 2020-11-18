using System.Runtime.Serialization;

namespace VoicifyAlexa.NET.Management.InteractionModel
{
    public enum FallbackIntentSensitivityLevel
    {
        [EnumMember(Value="LOW")]
        Low,
        [EnumMember(Value = "MEDIUM")]
        Medium,
        [EnumMember(Value = "HIGH")]
        High
    }
}