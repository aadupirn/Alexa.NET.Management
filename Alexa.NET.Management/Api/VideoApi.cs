using System.Collections.Generic;

namespace VoicifyAlexa.NET.Management.Api
{
    public class VideoApi:IApi
    {
        public Dictionary<string,VideoLocale> Locales { get; set; }

        public Dictionary<string,VideoRegion> Regions { get; set; }
    }
}