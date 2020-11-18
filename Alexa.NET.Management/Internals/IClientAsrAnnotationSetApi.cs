﻿using System.Net.Http;
using System.Threading.Tasks;
using VoicifyAlexa.NET.Management.Asr.AnnotationSet;
using Refit;

namespace VoicifyAlexa.NET.Management.Internals
{
    internal interface IClientAsrAnnotationSetApi
    {
        [Post("/v1/skills/{skillId}/asrAnnotationSets")]
        Task<HttpResponseMessage> Create(string skillId, [Body] Asr.AnnotationSet.CreateAnnotationSetRequest request);

        [Delete("/v1/skills/{skillId}/asrAnnotationSets/{annotationSetId}")]
        Task<HttpResponseMessage> Delete(string skillId, string annotationSetId);

        [Get("/v1/skills/{skillId}/asrAnnotationSets/{annotationSetId}/annotations")]
        Task<HttpResponseMessage> GetContent(string skillId, string annotationSetId, [Header("Accept")] string contentType);
        [Get("/v1/skills/{skillId}/asrAnnotationSets/{annotationSetId}/annotations")]
        Task<AnnotationSetResponse> GetContent(string skillId, string annotationSetId, int maxResults, [Header("Accept")] string contentType);
        [Get("/v1/skills/{skillId}/asrAnnotationSets/{annotationSetId}/annotations")]
        Task<AnnotationSetResponse> GetContent(string skillId, string annotationSetId, string nextToken, [Header("Accept")] string contentType);
        [Get("/v1/skills/{skillId}/asrAnnotationSets/{annotationSetId}/annotations")]
        Task<AnnotationSetResponse> GetContent(string skillId, string annotationSetId, int maxResults, string nextToken, [Header("Accept")] string contentType);

        [Get("/v1/skills/{skillId}/asrAnnotationSets/{annotationSetId}")]
        Task<AnnotationSetMetadata> GetMetadata(string skillId, string annotationSetId);

        [Get("/v1/skills/{skillId}/asrAnnotationSets")]
        Task<AnnotationSetListResponse> List(string skillId);

        [Get("/v1/skills/{skillId}/asrAnnotationSets")]
        Task<AnnotationSetListResponse> List(string skillId, int maxResults);

        [Get("/v1/skills/{skillId}/asrAnnotationSets")]
        Task<AnnotationSetListResponse> List(string skillId, string nextToken);

        [Get("/v1/skills/{skillId}/asrAnnotationSets")]
        Task<AnnotationSetListResponse> List(string skillId, int maxResults, string nextToken);

        [Put("/v1/skills/{skillId}/asrAnnotationSets/{annotationSetId}")]
        Task<HttpResponseMessage> UpdateName(string skillId, string annotationSetId, [Body]NameChangeRequest request);

        [Put("/v1/skills/{skillId}/asrAnnotationSets/{annotationSetId}/annotations")]
        Task<HttpResponseMessage> Update(string skillId, string annotationSetId, [Header("Content-Type")] string contentType, [Body]UpdateAnnotationsRequest request);

        [Put("/v1/skills/{skillId}/asrAnnotationSets/{annotationSetId}/annotations")]
        Task<HttpResponseMessage> Update(string skillId, string annotationSetId, [Header("Content-Type")] string contentType, [Body] string request);

    }
}
