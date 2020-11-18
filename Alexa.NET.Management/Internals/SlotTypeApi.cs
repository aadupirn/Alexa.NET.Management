﻿using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using VoicifyAlexa.NET.Management.SlotType;
using Refit;

namespace VoicifyAlexa.NET.Management.Internals
{
    public class SlotTypeApi : ISlotTypeApi
    {
        private IClientSlotTypeApi Client { get; }

        public SlotTypeApi(HttpClient client)
        {
            Client = RestService.For<IClientSlotTypeApi>(client, ManagementRefitSettings.Create());
        }

        public async Task<string> Create(string vendorId, string name, string description = null)
        {
            var response = await Client.Create(new CreateSlotRequest
            {
                VendorId = vendorId,
                SlotType = new SharedSlotType
                {
                    Name = name,
                    Description = description
                }
            });
            return response.SlotType.Id;
        }

        public async Task<SharedSlotType> Get(string slotId)
        {
            var response = await Client.Get(slotId);
            return response.SlotType;
        }

        public async Task Update(string slotId, string description)
        {
            var request = new UpdateRequest { SlotType = new SlotDescription { Description = description } };
            var response = await Client.Update(slotId, request);
            await response.CodeOrError(HttpStatusCode.NoContent);
        }

        public Task<ListSlotResponse> List(string vendorId, SortDirection sortDirection = SortDirection.Descending)
        {
            return Client.List(vendorId, sortDirection);
        }

        public Task<ListSlotResponse> List(string vendorId, int maxResults, SortDirection sortDirection = SortDirection.Descending)
        {
            return Client.List(vendorId, maxResults, sortDirection);
        }

        public Task<ListSlotResponse> List(string vendorId, string nextToken)
        {
            return Client.List(vendorId, nextToken);
        }

        public Task<ListSlotVersionsResponse> ListVersions(string slotId, SortDirection sortDirection = SortDirection.Descending)
        {
            return Client.ListVersions(slotId, sortDirection);
        }

        public Task<ListSlotVersionsResponse> ListVersions(string slotId, int maxResults, SortDirection sortDirection = SortDirection.Descending)
        {
            return Client.ListVersions(slotId, maxResults,sortDirection);
        }

        public Task<ListSlotVersionsResponse> ListVersions(string slotId, string nextToken)
        {
            return Client.ListVersions(slotId, nextToken);
        }

        public async Task Delete(string slotId)
        {
            var response = await Client.Delete(slotId);
            await response.CodeOrError(HttpStatusCode.NoContent);
        }

        public async Task<string> CreateVersion(string slotId, ValueSupplier supplier, string description = null)
        {
            var request = new Version
            {
                SlotType = new VersionSlotType
                {
                    Description = description,
                    Definition = new VersionDefinition(supplier)
                }
            };
            var response = await Client.CreateVersion(slotId, request);
            return await response.StringOrError(HttpStatusCode.Accepted);
        }

        public Task<CreatedVersion> Get(string slotId, string version)
        {
            return Client.GetVersion(slotId, version);
        }

        public Task<SlotBuildStatus> BuildStatus(string slotId, string updateRequestId)
        {
            return Client.BuildStatus(slotId, updateRequestId);
        }

        public async Task Update(string slotId, string version, string description)
        {
            var request = new UpdateRequest
            {
                SlotType = new SlotDescription
                {
                    Description = description
                }
            };
            var response = await Client.UpdateVersion(slotId, version, request);
            await response.CodeOrError(HttpStatusCode.NoContent);
        }
        public async Task Delete(string slotId, string versionId)
        {
            var response = await Client.DeleteVersion(slotId,versionId);
            await response.CodeOrError(HttpStatusCode.NoContent);
        }
    }
}