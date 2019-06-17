﻿using System.Linq;
using Alexa.NET.Management.Api;
using Alexa.NET.Management.Skills;

namespace Alexa.NET.Management.SkillSets
{
    public class SkillSetContext: ISkillSetContext
    {
        public SkillSetContext(SkillSummary summary, SkillSetOptions options)
        {
            Summary = summary;
            Options = options;
        }

        public string ID => Summary == null ? string.Empty : Summary.SkillId;
        public string Name => Summary == null ? string.Empty : Options.GetKeyByPreferredLocale(Summary.NameByLocale, s => s.First().Value);

        public SkillStage? Stage => Summary?.Stage;

        public SkillSetOptions Options { get; set; }

        public SkillSummary Summary { get; set; }

        public static ISkillSetContext Empty()
        {
            return new SkillSetContext(null,null);
        }
    }

    public interface ISkillSetContext:ISkillSetSummary
    {
    }
}