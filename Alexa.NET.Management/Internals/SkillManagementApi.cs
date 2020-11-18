﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using VoicifyAlexa.NET.Management.Api;
using VoicifyAlexa.NET.Management.Skills;
using VoicifyAlexa.NET.Response;
using Newtonsoft.Json;
using Refit;

namespace VoicifyAlexa.NET.Management.Internals
{
    public class SkillManagementApi : ISkillManagementApi
    {
        private IClientSkillManagementApi Inner { get; }

        public SkillManagementApi(HttpClient client)
        {
            Inner = RestService.For<IClientSkillManagementApi>(
                client, ManagementRefitSettings.Create(
                new JsonSerializerSettings
                {
                    Converters = new List<JsonConverter>(new[] { new ApiConverter(null) }),
                    NullValueHandling = NullValueHandling.Ignore
                }));
        }

        public Task<Skill> Get(string skillId, SkillStage stage)
        {
            return Inner.Get(skillId, stage);
        }

        public Task<SkillId> Create(string vendorId, Skill skill)
        {
            return Inner.Create(new SkillCreateRequest { VendorId = vendorId, Manifest = skill.Manifest });
        }

        public async Task<bool> Delete(string skillId)
        {
            var response = await Inner.Delete(skillId);
            return response.StatusCode == HttpStatusCode.NoContent;
        }

        public Task<SkillId> Update(string skillId, SkillStage stage, Skill skill)
        {
            return Inner.Update(skillId, stage, skill);
        }

        public Task<SkillStatus> Status(string skillId, params string[] resources)
        {
            return Inner.Status(skillId, new SkillResourceContainer(resources));
        }

        public async Task<SubmitResponse> Submit(string skillId, bool automaticPublishing = true)
        {
            var request = new SubmitRequest
            {
                PublicationMethod = automaticPublishing ? PublicationMethod.Automatic : PublicationMethod.Manual
            };

            var response = await Inner.Submit(skillId,request);
            var uri = await response.UriOrError(HttpStatusCode.Accepted);

            return new SubmitResponse
            {
                Location = uri
            };
        }

        public Task Withdraw(string skillId, WithdrawalRequest request)
        {
            return Inner.Withdraw(skillId, request);
        }

        public Task<UnpublishResponse> Unpublish(string skillId, UnpublishType type, UnpublishReason reason)
        {
            return Inner.Unpublish(skillId, new UnpublishRequest
            {
                Type = type,
                Reason = reason
            });
        }

        public Task<InvocationResponse> Invoke(string skillId, SkillStage stage, InvocationRequest request)
        {
            return Inner.Invoke(skillId, stage, request);
        }

        public Task<SimulationResponse> Simulate(string skillId, SkillStage stage, SimulationRequest request)
        {
            return Inner.Simulate(skillId, stage, request);
        }

        public Task<SimulationResponse> SimulationResult(string skillId, SkillStage stage, string simulationId)
        {
            return Inner.SimulationResult(skillId, stage, simulationId);
        }

        public Task<SkillListResponse> List(string vendorId)
        {
            return Inner.List(vendorId);
        }

        public Task<SkillListResponse> List(string vendorId, params string[] container)
        {
            return Inner.List(vendorId, new SkillIdContainer(container));
        }

        public Task<SkillListResponse> List(string vendorId, int maxResults)
        {
            return Inner.List(vendorId, maxResults);
        }

        public Task<SkillListResponse> List(string vendorId, int maxResults, string nextToken)
        {
            return Inner.List(vendorId, maxResults, nextToken);
        }

        public Task<CertificationListResponse> ListCertification(string skillId)
        {
            return Inner.ListCertification(skillId);
        }

        public Task<CertificationListResponse> ListCertification(string skillId, int maxResults)
        {
            return Inner.ListCertification(skillId, maxResults);
        }

        public Task<CertificationListResponse> ListCertification(string skillId, int maxResults, string nextToken)
        {
            return Inner.ListCertification(skillId, maxResults, nextToken);
        }

        public Task<Certification> Certification(string skillId, string certificationId)
        {
            return Inner.Certification(skillId, certificationId);
        }

        public Task<Certification> Certification(string skillId, string certificationId, string locale)
        {
            return Inner.Certification(skillId, certificationId, locale);
        }

        public async Task<PublishResponse> Publish(string skillId, DateTime? publishDate)
        {
            Task<HttpResponseMessage> publishTask;
            if (publishDate.HasValue)
            {
                publishTask = Inner.Publish(skillId, new PublishRequest {PublishesAt = publishDate.Value});
            }
            else
            {
                publishTask = Inner.Publish(skillId);
            }

            var response = await publishTask;

            var body = await response.Content.ReadAsStringAsync();
            if (response.StatusCode != HttpStatusCode.Accepted)
            {
                throw new InvalidOperationException(
                    $"Expected Status Code 202. Received {(int)response.StatusCode}. Response Body: {body}");
            }

            return JsonConvert.DeserializeObject<PublishResponse>(body);
        }
    }
}
