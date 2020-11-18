﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using VoicifyAlexa.NET.Management.Api;
using VoicifyAlexa.NET.Management.InteractionModel;
using VoicifyAlexa.NET.Management.Skills;
using Refit;

namespace VoicifyAlexa.NET.Management.Internals
{
    public class InteractionModelApi : IInteractionModelApi
    {
        private IClientInteractionModelApi Client { get; }

        public InteractionModelApi(HttpClient httpClient)
        {
            Client = RestService.For<IClientInteractionModelApi>(httpClient,ManagementRefitSettings.Create());
        }

        public Task<SkillInteractionContainer> Get(string skillId, SkillStage stage, string locale)
        {
            return Client.Get(skillId, stage, locale);
        }

        public async Task<string> GetTag(string skillId, SkillStage stage, string locale)
        {
            var message = await Client.GetTag(skillId, stage, locale);
            return message.Headers.ETag.Tag;
        }

        public Task Update(string skillId, SkillStage stage, string locale, SkillInteractionContainer interaction)
        {
            return Client.Update(skillId, stage, locale, interaction);
        }

        public Task<InteractionModelVersionsResponse> Versions(string skillId, string locale)
        {
            return Client.Versions(skillId, locale);
        }

        public Task<InteractionModelVersionsResponse> Versions(string skillId, string locale, SortDirection sortDirection)
        {
            return Client.Versions(skillId, locale, sortDirection);
        }

        public Task<InteractionModelVersionsResponse> Versions(string skillId, string locale, string nextToken, int maxResults)
        {
            return Client.Versions(skillId, locale, nextToken, maxResults);
        }

        public Task<InteractionModelVersionsResponse> Versions(string skillId, string locale, SortDirection sortDirection, string nextToken,
            int maxResults)
        {
            return Client.Versions(skillId, locale, sortDirection, nextToken, maxResults);
        }

        public Task<SkillModelVersion> Version(string skillId, string locale, string version)
        {
            return Client.Version(skillId, locale, version);
        }
    }
}