using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VoicifyAlexa.NET.Management.IntentRequestHistory;
using Refit;

namespace VoicifyAlexa.NET.Management.Internals
{
    internal interface IClientIntentRequestHistoryApi
    {
        [Get("/v1/skills/{skillId}/history/intentRequests")]
        Task<IntentRequestHistoryResponse> Get(string skillId, ClientIntentRequestHistoryRequest request);
    }
}
