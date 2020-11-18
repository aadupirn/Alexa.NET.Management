﻿using System.Threading.Tasks;
using VoicifyAlexa.NET.Management.SlotType;

namespace VoicifyAlexa.NET.Management
{
    public interface ISlotTypeApi
    {
        Task<string> Create(string vendorId, string slotName, string description = null);
        Task<SharedSlotType> Get(string slotId);
        Task Update(string slotId, string description);

        Task<ListSlotResponse> List(string vendorId, SortDirection sortDirection = SortDirection.Descending);

        Task<ListSlotResponse> List(string vendorId, int maxResults,
            SortDirection sortDirection = SortDirection.Descending);

        Task<ListSlotResponse> List(string vendorId, string nextToken);

        Task<ListSlotVersionsResponse> ListVersions(string slotId, SortDirection sortDirection = SortDirection.Descending);

        Task<ListSlotVersionsResponse> ListVersions(string slotId, int maxResults,
            SortDirection sortDirection = SortDirection.Descending);

        Task<ListSlotVersionsResponse> ListVersions(string slotId, string nextToken);

        Task Delete(string slotId);

        Task<string> CreateVersion(string slotId, ValueSupplier supplier, string description = null);
        Task<CreatedVersion> Get(string slotId, string version);
        Task<SlotBuildStatus> BuildStatus(string slotId, string updateRequestId);
        Task Update(string slotId, string version, string description);

        Task Delete(string slotId, string version);
    }
}
