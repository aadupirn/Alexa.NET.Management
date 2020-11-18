using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Skills
{
    public class CertificationResult
    {
        [JsonProperty("distributionInfo")]
        public DistributionInformation DistributionInformation { get; set; }
    }
}