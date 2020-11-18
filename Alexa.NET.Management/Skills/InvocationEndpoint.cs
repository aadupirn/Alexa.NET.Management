using System.Runtime.Serialization;

namespace VoicifyAlexa.NET.Management
{
    public enum InvocationEndpoint
    {
        [EnumMember(Value="Default")]
        Default,
        [EnumMember(Value="NA")]
        NorthAmerica,
        [EnumMember(Value="EU")]
        Europe,
        [EnumMember(Value="FE")]
        FarEast
    }
}