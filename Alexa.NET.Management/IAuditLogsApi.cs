using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VoicifyAlexa.NET.Management.Audit;
using Refit;

namespace VoicifyAlexa.NET.Management
{
    public interface IAuditLogsApi
    {
        [Post("/v1/developmentAuditLogs/query")]
        Task<QueryResponse> Query([Body]QueryRequest request);
    }
}
