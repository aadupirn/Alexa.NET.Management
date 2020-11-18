﻿using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using VoicifyAlexa.NET.Management.Asr.AnnotationSet;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Refit;

namespace VoicifyAlexa.NET.Management.Internals
{
    public class AsrAnnotationSetsApi : IAsrAnnotationSetsApi
    {
        private IClientAsrAnnotationSetApi Client { get; }
        public AsrAnnotationSetsApi(HttpClient client)
        {
            Client = RestService.For<IClientAsrAnnotationSetApi>(client);
        }

        public async Task<Asr.AnnotationSet.CreateAnnotationSetResponse> Create(string skillId, string name)
        {
            var response = await Client.Create(skillId, new Asr.AnnotationSet.CreateAnnotationSetRequest {Name=name});

            var body = string.Empty;
            if (response.Content != null)
            {
                body = await response.Content.ReadAsStringAsync();
            }

            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new InvalidOperationException(
                    $"Expected Status Code 200. Received {(int)response.StatusCode}. Response Body: {body}");
            }

            var json = JObject.Parse(body);
            return new Asr.AnnotationSet.CreateAnnotationSetResponse
            {
                Id = json.Value<string>("id"),
                Location = response.Headers.Location
            };
        }

        public async Task Delete(string skillId, string annotationSetId)
        {
            var response = await Client.Delete(skillId, annotationSetId);
            await response.CodeOrError(HttpStatusCode.NoContent);
        }

        public async Task<AnnotationSetResponse> GetContent(string skillId, string annotationSetId)
        {
            var response = await Client.GetContent(skillId, annotationSetId, "application/json");
            return await response.BodyOrError(JsonConvert.DeserializeObject<AnnotationSetResponse>, HttpStatusCode.OK);
        }

        public Task<AnnotationSetResponse> GetContent(string skillId, string annotationSetId, int maxResults)
        {
            return Client.GetContent(skillId, annotationSetId, maxResults, "application/json");
        }

        public Task<AnnotationSetResponse> GetContent(string skillId, string annotationSetId, string nextToken)
        {
            return Client.GetContent(skillId, annotationSetId, nextToken, "application/json");
        }

        public Task<AnnotationSetResponse> GetContent(string skillId, string annotationSetId, int maxResults, string nextToken)
        {
            return Client.GetContent(skillId, annotationSetId, maxResults, nextToken, "application/json");
        }

        public async Task<string> GetContentCsv(string skillId, string annotationSetId)
        {
            var response = await Client.GetContent(skillId, annotationSetId, "text/csv");
            return await response.BodyOrError(s => s, HttpStatusCode.OK);
        }

        public Task<AnnotationSetMetadata> GetMetadata(string skillId, string annotationSetId)
        {
            return Client.GetMetadata(skillId, annotationSetId);
        }

        public Task<AnnotationSetListResponse> List(string skillId)
        {
            return Client.List(skillId);
        }

        public Task<AnnotationSetListResponse> List(string skillId, int maxResults)
        {
            return Client.List(skillId, maxResults);
        }

        public Task<AnnotationSetListResponse> List(string skillId, string nextToken)
        {
            return Client.List(skillId, nextToken);
        }

        public Task<AnnotationSetListResponse> List(string skillId, int maxResults, string nextToken)
        {
            return Client.List(skillId, maxResults, nextToken);
        }

        public  async Task Update(string skillId, string annotationSetId, AnnotationUpdate[] annotationUpdates)
        {
            var response = await Client.Update(skillId, annotationSetId, "application/json",
                new UpdateAnnotationsRequest {Annotations = annotationUpdates});
            await response.CodeOrError(HttpStatusCode.NoContent);
        }

        public async Task Update(string skillId, string annotationSetId, string csvWithHeaders)
        {
            var response = await Client.Update(skillId, annotationSetId, "text/csv",csvWithHeaders);
            await response.CodeOrError(HttpStatusCode.NoContent);
        }

        public async Task ChangeName(string skillId, string annotationSetId, string name)
        {
            var response = await Client.UpdateName(skillId, annotationSetId,new NameChangeRequest{Name=name});
            await response.CodeOrError(HttpStatusCode.NoContent);
        }
    }
}