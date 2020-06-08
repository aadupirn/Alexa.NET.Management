﻿using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Alexa.NET.Management.Asr.AnnotationSet;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Refit;

namespace Alexa.NET.Management.Internals
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

        public async Task<AnnotationSetResponse> Get(string skillId, string annotationSetId)
        {
            var response = await Client.Get(skillId, annotationSetId, "application/json");
            return await response.BodyOrError(JsonConvert.DeserializeObject<AnnotationSetResponse>, HttpStatusCode.OK);
        }

        public Task<AnnotationSetResponse> Get(string skillId, string annotationSetId, int maxResults)
        {
            return Client.Get(skillId, annotationSetId, maxResults, "application/json");
        }

        public Task<AnnotationSetResponse> Get(string skillId, string annotationSetId, string nextToken)
        {
            return Client.Get(skillId, annotationSetId, nextToken, "application/json");
        }

        public Task<AnnotationSetResponse> Get(string skillId, string annotationSetId, int maxResults, string nextToken)
        {
            return Client.Get(skillId, annotationSetId, maxResults, nextToken, "application/json");
        }

        public async Task<string> GetCsv(string skillId, string annotationSetId)
        {
            var response = await Client.Get(skillId, annotationSetId, "text/csv");
            return await response.BodyOrError(s => s, HttpStatusCode.OK);
        }
    }
}