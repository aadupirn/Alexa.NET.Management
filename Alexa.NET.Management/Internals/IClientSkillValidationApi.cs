using System.Threading.Tasks;
using VoicifyAlexa.NET.Management.Api;
using VoicifyAlexa.NET.Management.Validation;
using Refit;

namespace VoicifyAlexa.NET.Management.Internals
{
    public interface IClientSkillValidationApi
    {
        [Post("/v1/skills/{skillId}/stage/{stage}/validations")]
        Task<SkillValidationResponse> Submit(string skillId, SkillStage stage);

        [Post("/v1/skills/{skillId}/stage/{stage}/validations")]
        Task<SkillValidationResponse> Submit(string skillId, SkillStage stage, [Body]SkillValidationRequest request);

        [Get("/v1/skills/{skillId}/stages/{stage}/validations/{validationId}")]
        Task<SkillValidationResponse> Get(string skillId, SkillStage stage, string validationId);
    }
}
