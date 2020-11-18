﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using VoicifyAlexa.NET.Management.AccountLinking;
using VoicifyAlexa.NET.Management.Api;
using Refit;

namespace VoicifyAlexa.NET.Management.Internals
{
    public interface IClientAccountLinkingApi
    {
        [Get("/v1/skills/{skillId}/stages/{stage}/accountLinkingClient")]
        Task<AccountLinkInformation> Get(string skillId, SkillStage stage);

        [Put("/v1/skills/{skillId}/stages/{stage}/accountLinkingClient")]
        Task Update(string skillId, SkillStage stage, [Body]AccountLinkUpdate information);

        [Delete("/v1/skills/{skillId}/stages/{stage}/accountLinkingClient")]
        Task<HttpResponseMessage> Delete(string skillId, SkillStage stage);
    }
}
