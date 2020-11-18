using VoicifyAlexa.NET.Management.Api;
using VoicifyAlexa.NET.Management.InSkillProduct;

namespace VoicifyAlexa.NET.Management
{
    public class GetInSkillProductFilters
    {
        public SkillStage? Stage { get; set; }
        public ProductStatus? Status { get; set; }
        public string Type { get; set; }
        public bool? IsAssociatedWithSkill { get; set; }
    }
}