using System.Threading.Tasks;
using VoicifyAlexa.NET.Management.Api;
using VoicifyAlexa.NET.Management.UtteranceProfiler;
using Refit;

namespace VoicifyAlexa.NET.Management.Internals
{
    interface IClientUtteranceProfilerApi
    {
        [Post("/v1/skills/{skillId}/stages/{stage}/interactionModel/locales/{locale}/profileNlu")]
        Task<UtteranceProfilerResponse> Analyze(string skillId, SkillStage stage, string locale, UtteranceProfilerRequest request);
    }
}
