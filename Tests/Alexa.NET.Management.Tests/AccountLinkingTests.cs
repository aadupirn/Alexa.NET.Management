using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using VoicifyAlexa.NET.Management.AccountLinking;
using VoicifyAlexa.NET.Management.Api;
using VoicifyAlexa.NET.Management.Internals;
using Xunit;

namespace VoicifyAlexa.NET.Management.Tests
{
    public class AccountLinkingTests
    {
        [Fact]
        public async Task Get()
        {
            var management = new ManagementApi("xxx", new ActionHandler(req =>
            {
                Assert.Equal(HttpMethod.Get, req.Method);
                Assert.Equal("/v1/skills/skillId/stages/development/accountLinkingClient", req.RequestUri.PathAndQuery);
            }, new AccountLinkData()));
            var response = await management.AccountLinking.Get("skillId",SkillStage.Development);
        }
    }
}
