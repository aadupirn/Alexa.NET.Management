using System.Threading.Tasks;
using VoicifyAlexa.NET.Management.Skills;

namespace VoicifyAlexa.NET.Management.SkillSets
{
    public interface ISkillSetContextSimulationApi
    {
        Task<SimulationResponse> NewSession(string message);
        Task<SimulationResponse> SendNextMessage(string message);

        Task<SimulationResult> WaitForResult(SimulationResponse response, int pollSeconds);
    }
}