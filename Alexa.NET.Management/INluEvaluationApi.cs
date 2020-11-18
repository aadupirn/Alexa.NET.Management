using System.Threading.Tasks;
using VoicifyAlexa.NET.Management.Api;
using VoicifyAlexa.NET.Management.Nlu.Evaluation;

namespace VoicifyAlexa.NET.Management
{
    public interface INluEvaluationApi
    {
        Task<CreateEvaluationResponse> Create(string skillId, SkillStage stage, string locale, string annotationId);

        Task<ListEvaluationResponse> List(string skillId, ListEvaulationFilters filters = null);

        Task<ListEvaluationResponse> List(string skillId, string nextToken, ListEvaulationFilters filters = null);

        Task<EvaluationStatusWithLinks> Get(string skillId, string evaluationId);

        Task<EvaluationResults> Results(string skillId, string evaluationId, EvaluationResultRequest request = default);
        Task<EvaluationResults> Results(string skillId, string evaluationId, string nextToken, EvaluationResultRequest request = default);
    }
}
