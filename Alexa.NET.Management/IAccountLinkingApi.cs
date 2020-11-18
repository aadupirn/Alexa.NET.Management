using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VoicifyAlexa.NET.Management.AccountLinking;
using VoicifyAlexa.NET.Management.Api;
using Refit;

namespace VoicifyAlexa.NET.Management
{
    public interface IAccountLinkingApi
    {
        Task<AccountLinkData> Get(string skillId, SkillStage stage);
        Task<bool> Delete(string skillId);
        Task Update(string skillId, AccountLinkData accountLinkData);
    }
}
