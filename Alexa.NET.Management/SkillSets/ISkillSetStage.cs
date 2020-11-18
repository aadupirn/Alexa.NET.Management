namespace VoicifyAlexa.NET.Management.SkillSets
{
    public interface ISkillSetStage:ISkillSetSummary
    {
        SkillSetLocale[] Locales { get;  }
    }
}