using System;
using System.Collections.Generic;
using System.Text;
using VoicifyAlexa.NET.Management.Api;

namespace VoicifyAlexa.NET.Management.SkillSets
{
    public interface ISkillSetSummary
    {
        string ID { get; }
        string Name { get; }

        SkillStage? Stage { get; }
    }
}
