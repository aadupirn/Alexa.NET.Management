using System;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.InSkillProduct
{
    public class Pricing<T>  {
        [JsonProperty("releaseDate")]
        public DateTime ReleaseDateUtc { get; set; }

        [JsonProperty("defaultPriceListing")]
        public T DefaultPriceListing { get; set; }
    }
}