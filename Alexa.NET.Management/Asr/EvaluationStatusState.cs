using System.Runtime.Serialization;

namespace VoicifyAlexa.NET.Management.Asr.Evaluations
{
    public enum EvaluationStatusState
    {
        [EnumMember(Value="COMPLETED")]
        Completed,
        [EnumMember(Value="IN_PROGRESS")]
        InProgress,
        [EnumMember(Value="FAILED")]
        Failed
    }
}