using System;
using System.Threading.Tasks;
using VoicifyAlexa.NET.Management.ReferenceCatalogManagement;

namespace VoicifyAlexa.NET.Management
{
    public interface IUpdateJobsManagementApi
    {
        Task<string> Create(string vendorId, IUpdateJobDefinition job);

        Task<IUpdateJobDefinition> Get(string jobId);

        Task<UpdateJobListResponse> List(string vendorId);

        Task<UpdateJobListResponse> List(string vendorId, int maxCount);

        Task<UpdateJobListResponse> List(string vendorId, string nextToken);

        Task<UpdateJobListResponse> List(string vendorId, int maxCount, string nextToken);

        Task Delete(string jobId);

        Task<UpdateJobExecutionHistoryResponse> ListExecutionHistory(string jobId);

        Task<UpdateJobExecutionHistoryResponse> ListExecutionHistory(string jobId, SortDirection sortDirection);

        Task<UpdateJobExecutionHistoryResponse> ListExecutionHistory(string jobId, string nextToken, int maxResults);

        Task<UpdateJobExecutionHistoryResponse> ListExecutionHistory(string jobId, SortDirection sortDirection,
            string nextToken, int maxResults);


        Task CancelNextExecution(string jobId, string executionId);

        Task SetJobStatus(string jobId, UpdateJobStatus status);
    }
}