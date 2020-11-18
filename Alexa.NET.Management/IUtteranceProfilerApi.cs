using System.Threading.Tasks;
using VoicifyAlexa.NET.Management.Api;
using VoicifyAlexa.NET.Management.UtteranceProfiler;

namespace VoicifyAlexa.NET.Management
{
    public interface IUtteranceProfilerApi
    {
        Task<UtteranceProfilerResponse> Analyze(string skillId, SkillStage stage, string locale,string utterance, string multiTurnToken = null);
    }
}
