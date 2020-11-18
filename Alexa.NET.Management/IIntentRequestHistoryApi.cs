using System.Threading.Tasks;
using VoicifyAlexa.NET.Management.IntentRequestHistory;
using Refit;

namespace VoicifyAlexa.NET.Management
{
    public interface IIntentRequestHistoryApi
    {
        [Get("/v1/skills/{skillId}/history/intentRequests")]
        Task<IntentRequestHistoryResponse> Get(string skillId, IntentRequestHistoryRequest request);
    }
}