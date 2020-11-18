using System;
using System.Net.Http;
using System.Threading.Tasks;
using VoicifyAlexa.NET.Management.Api;
using VoicifyAlexa.NET.Management.UtteranceProfiler;
using Refit;

namespace VoicifyAlexa.NET.Management.Internals
{
    public class SkillUtteranceProfilerApi:IUtteranceProfilerApi
    {
        private IClientUtteranceProfilerApi Client { get; }

        public SkillUtteranceProfilerApi(HttpClient client)
        {
            Client = RestService.For<IClientUtteranceProfilerApi>(client, ManagementRefitSettings.Create());
        }

        public Task<UtteranceProfilerResponse> Analyze(string skillId, SkillStage stage, string locale, string utterance, string multiTurnToken = null)
        {
            return Client.Analyze(skillId, stage, locale, new UtteranceProfilerRequest(utterance, multiTurnToken));
        }
    }
}
