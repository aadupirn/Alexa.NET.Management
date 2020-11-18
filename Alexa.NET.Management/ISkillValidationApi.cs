using System.Threading.Tasks;
using VoicifyAlexa.NET.Management.Api;
using VoicifyAlexa.NET.Management.Validation;

namespace VoicifyAlexa.NET.Management
{
    public interface ISkillValidationApi
    {
        Task<SkillValidationResponse> Submit(string skillId, SkillStage stage);
        Task<SkillValidationResponse> Submit(string skillId, SkillStage stage, params string[] locales);
        Task<SkillValidationResponse> Get(string skillid, SkillStage development, string validationid);
    }
}