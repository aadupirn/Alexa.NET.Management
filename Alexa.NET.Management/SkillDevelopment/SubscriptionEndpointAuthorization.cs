using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.SkillDevelopment
{
    public class SubscriptionEndpointAuthorization
    {
        public SubscriptionEndpointAuthorization(string arn)
        {
            ARN = arn;
        }

        [JsonProperty("type")] public string Type => "AWS_IAM";

        [JsonProperty("arn")]
        public string ARN { get; set; }
    }
}