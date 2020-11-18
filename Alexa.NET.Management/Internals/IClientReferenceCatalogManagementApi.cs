﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using VoicifyAlexa.NET.Management.ReferenceCatalogManagement;
using Refit;

namespace VoicifyAlexa.NET.Management.Internals
{
    internal interface IClientReferenceCatalogManagementApi
    {
        [Post("/v1/skills/api/custom/interactionModel/catalogs")]
        public Task<ReferenceCatalogCreationResponse> Create(ReferenceCatalogCreationRequest request);

        [Post("/v1/skills/api/custom/interactionModel/catalogs/{catalogId}/versions")]
        public Task<HttpResponseMessage> CreateVersion(string catalogId, ReferenceCatalogCreateVersionRequest request);

        [Get("/v1/skills/api/custom/interactionModel/catalogs/{catalogId}/updateRequest/{updateRequestId}")]
        public Task<ReferenceCatalogUpdateStatus> GetUpdateStatus(string catalogId, string updateRequestId);

        [Get("/v1/skills/api/custom/interactionModel/catalogs")]
        Task<ReferenceCatalogListResponse> List(string vendorId);

        [Get("/v1/skills/api/custom/interactionModel/catalogs")]
        Task<ReferenceCatalogListResponse> List(string vendorId, SortDirection sortDirection);

        [Get("/v1/skills/api/custom/interactionModel/catalogs")]
        Task<ReferenceCatalogListResponse> List(string vendorId, string nextToken, int maxResults);

        [Get("/v1/skills/api/custom/interactionModel/catalogs")]
        Task<ReferenceCatalogListResponse> List(string vendorId, SortDirection sortDirection, string nextToken, int maxResults);

        [Get("/v1/skills/api/custom/interactionModel/catalogs/{catalogId}/versions")]
        Task<ReferenceCatalogListVersionsResponse> ListVersions(string catalogId);

        [Get("/v1/skills/api/custom/interactionModel/catalogs/{catalogId}/versions")]
        Task<ReferenceCatalogListVersionsResponse> ListVersions(string catalogId, SortDirection sortDirection);

        [Get("/v1/skills/api/custom/interactionModel/catalogs/{catalogId}/versions")]
        Task<ReferenceCatalogListVersionsResponse> ListVersions(string catalogId, string nextToken, int maxResults);

        [Get("/v1/skills/api/custom/interactionModel/catalogs/{catalogId}/versions")]
        Task<ReferenceCatalogListVersionsResponse> ListVersions(string catalogId, SortDirection sortDirection, string nextToken, int maxResults);

        [Get("/v1/skills/api/custom/interactionModel/catalogs/{catalogId}")]
        Task<ReferenceCatalogDefinition> Get(string catalogId);

        [Get("/v1/skills/api/custom/interactionModel/catalogs/{catalogId}/versions/{version}")]
        Task <ReferenceCatalogVersionDefinition> GetVersion(string catalogId, string version);

        [Get("/v1/skills/api/custom/interactionModel/catalogs/{catalogId}/versions/{version}/values")]
        Task<ReferenceCatalogValuesResponse> GetValues(string catalogId, string version);

        [Get("/v1/skills/api/custom/interactionModel/catalogs/{catalogId}/versions/{version}/values")]
        Task<ReferenceCatalogValuesResponse> GetValues(string catalogId, string version, int maxResults);

        [Get("/v1/skills/api/custom/interactionModel/catalogs/{catalogId}/versions/{version}/values")]
        Task<ReferenceCatalogValuesResponse> GetValues(string catalogId, string version, int nextToken, int maxResults);

        [Post("/v1/skills/api/custom/interactionModel/catalogs/{catalogId}/update")]
        Task<HttpResponseMessage> Update(string catalogId, ReferenceCatalog catalog);

        [Post("/v1/skills/api/custom/interactionModel/catalogs/{catalogId}/versions/{version}/update")]
        Task<HttpResponseMessage> UpdateVersion(string catalogId, string version, ReferenceCatalogVersionUpdate update);

        [Delete("/v1/skills/api/custom/interactionModel/catalogs/{catalogId}")]
        Task<HttpResponseMessage> Delete(string catalogId);

        [Delete("/v1/skills/api/custom/interactionModel/catalogs/{catalogId}/versions/{version}")]
        Task<HttpResponseMessage> DeleteVersion(string catalogId, string version);
    }
}
