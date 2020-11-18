using System.Threading.Tasks;
using Refit;

namespace VoicifyAlexa.NET.Management
{
    public interface IVendorApi
    {
        [Get("/v1/vendors")]
        Task<VendorResponse> Get();
    }
}
