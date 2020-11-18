using System.Runtime.Serialization;

namespace VoicifyAlexa.NET.Management.Skills
{
    public enum InvocationStatus
    {
        [EnumMember(Value="SUCCESSFUL")]
        Successful,
        [EnumMember(Value="FAILED")]
        Failed,
        [EnumMember(Value="IN_PROGRESS")]
        InProgress
    }
}