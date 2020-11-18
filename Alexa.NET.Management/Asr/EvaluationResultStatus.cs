using System.Runtime.Serialization;

namespace VoicifyAlexa.NET.Management.Asr.Evaluations
{
    public enum EvaluationResultStatus
    {
        [EnumMember(Value="PASSED")]
        Passed,
        [EnumMember(Value = "FAILED")]
        Failed
    }
}