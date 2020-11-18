using System.Runtime.Serialization;

namespace VoicifyAlexa.NET.Management.Nlu.Evaluation
{
    public enum EvaluationSortField
    {
        [EnumMember(Value = "STATUS")]
        Status,
        [EnumMember(Value = "ACTUAL_INTENT")]
        ActualIntent,
        [EnumMember(Value = "EXPECTED_INTENT")]
        ExpectedIntent
    }
}