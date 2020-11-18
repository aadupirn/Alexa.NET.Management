using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace VoicifyAlexa.NET.Management.Api
{
    public enum SkillStage
    {
        [EnumMember(Value="development")]
        Development,
        [EnumMember(Value="live")]
        Live
    }
}
