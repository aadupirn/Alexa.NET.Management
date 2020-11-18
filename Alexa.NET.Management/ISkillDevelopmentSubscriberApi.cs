using System;
using System.Threading.Tasks;
using VoicifyAlexa.NET.Management.SkillDevelopment;

namespace VoicifyAlexa.NET.Management
{
    public interface ISkillDevelopmentSubscriberApi
    {
        Task<Uri> Create(Subscriber request);
        Task Delete(string subscriberId);
        Task<ListedSubscriber> Get(string subscriberId);

        Task<ListSubscriberResponse> List(string vendorId);

        Task<ListSubscriberResponse> List(string vendorId, int maxResults);

        Task<ListSubscriberResponse> List(string vendorId, int maxResults, string nextToken);

        Task Update(string subscriberId, SubscriberUpdate subscriberDetails);
    }
}