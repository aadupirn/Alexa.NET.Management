using System.Net.Http;
using System.Threading.Tasks;
using VoicifyAlexa.NET.Management.Api;
using VoicifyAlexa.NET.Management.InteractionModel;
using VoicifyAlexa.NET.Management.Skills;
using Refit;

namespace VoicifyAlexa.NET.Management.Internals
{
    public interface IClientInteractionModelApi
    {
        [Get("/v1/skills/{skillId}/stages/{stage}/interactionModel/locales/{locale}")]
        Task<SkillInteractionContainer> Get(string skillId, SkillStage stage, string locale);

        [Head("/skills/{skillId}/stages/{stage}/interactionModel/locales/{locale}")]
        Task<HttpResponseMessage> GetTag(string skillId, SkillStage stage, string locale);

        [Put("/v1/skills/{skillId}/stages/{stage}/interactionModel/locales/{locale}")]
        Task Update(string skillId, SkillStage stage, string locale, [Body]SkillInteractionContainer interaction);

        [Get("/v1/skills/{skillId}/stages/development/interactionModel/locales/{locale}/versions")]
        Task<InteractionModelVersionsResponse> Versions(string skillId, string locale);

        [Get("/v1/skills/{skillId}/stages/development/interactionModel/locales/{locale}/versions")]
        Task<InteractionModelVersionsResponse> Versions(string skillId, string locale, SortDirection sortDirection);

        [Get("/v1/skills/{skillId}/stages/development/interactionModel/locales/{locale}/versions")]
        Task<InteractionModelVersionsResponse> Versions(string skillId, string locale, string nextToken, int maxResults);

        [Get("/v1/skills/{skillId}/stages/development/interactionModel/locales/{locale}/versions")]
        Task<InteractionModelVersionsResponse> Versions(string skillId, string locale, SortDirection sortDirection, string nextToken, int maxResults);

        [Get("/v1/skills/{skillId}/stages/development/interactionModel/locales/{locale}/versions/{version}")]
        Task<SkillModelVersion> Version(string skillId, string locale, string version);


    }
}