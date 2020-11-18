using System.IO;
using System.Linq;
using VoicifyAlexa.NET.Management.Api;
using VoicifyAlexa.NET.Management.Skills;
using Newtonsoft.Json;
using Xunit;

namespace VoicifyAlexa.NET.Management.Tests
{
    public class SkillListConversionTests
    {
        [Fact]
        public void CreatesList()
        {
            var response = Utility.ExampleFileContent<SkillListResponse>("SkillListResponse.json");
            Assert.Single(response.Skills);
        }

        [Fact]
        public void SkillListDetailsAreCorrect()
        {
            var response = Utility.ExampleFileContent<SkillListResponse>("SkillListResponse.json");
            var skill = response.Skills.First();
            Assert.Equal("amzn1.ask.skill.6acdbdf8-8420-440e-823e-aaaaaaaabbbb", skill.SkillId);
            Assert.Equal(PublicationStatus.Published,skill.Status);
            Assert.Equal(SkillStage.Development,skill.Stage);
        }
    }
}
