using System.Runtime.Serialization;

namespace VoicifyAlexa.NET.Management.Nlu.Evaluation
{
    public enum TestCaseStatus
    {
        [EnumMember(Value = "PASSED")]
        Passed,
        [EnumMember(Value = "FAILED")]
        Failed
    }
}