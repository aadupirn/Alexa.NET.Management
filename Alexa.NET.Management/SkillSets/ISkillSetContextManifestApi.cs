using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VoicifyAlexa.NET.Management.Manifest;

namespace VoicifyAlexa.NET.Management.SkillSets
{
    public interface ISkillSetContextManifestApi
    {
        Task<SkillManifest> Get();
    }
}
