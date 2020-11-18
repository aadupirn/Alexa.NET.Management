using System.Net.Http;
using Refit;

namespace VoicifyAlexa.NET.Management
{
    public interface ISkillDevelopmentApi
    {
        ISkillDevelopmentSubscriberApi Subscriber { get; }
        ISkillDevelopmentSubscriptionApi Subscription { get; }
    }
}
