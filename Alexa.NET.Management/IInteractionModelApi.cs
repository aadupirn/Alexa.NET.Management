﻿using System.Threading.Tasks;
using VoicifyAlexa.NET.Management.Api;
using VoicifyAlexa.NET.Management.InteractionModel;
using VoicifyAlexa.NET.Management.Skills;

namespace VoicifyAlexa.NET.Management
{
    public interface IInteractionModelApi
    {
        Task<SkillInteractionContainer> Get(string skillId, SkillStage stage, string locale);

        Task<string> GetTag(string skillId, SkillStage stage, string locale);

        Task Update(string skillId, SkillStage stage, string locale, SkillInteractionContainer interaction);

        Task<InteractionModelVersionsResponse> Versions(string skillId, string locale);

        Task<InteractionModelVersionsResponse> Versions(string skillId, string locale, SortDirection sortDirection);

        Task<InteractionModelVersionsResponse> Versions(string skillId, string locale, string nextToken, int maxResults);

        Task<InteractionModelVersionsResponse> Versions(string skillId, string locale, SortDirection sortDirection, string nextToken, int maxResults);

        Task<SkillModelVersion> Version(string skillId, string locale, string version);
    }
}
