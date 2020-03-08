﻿using System.Net.Http;
using System.Threading.Tasks;
using Alexa.NET.Management.SlotType;
using Refit;

namespace Alexa.NET.Management.Internals
{
    public class SlotTypeApi:ISlotTypeApi
    {
        private IClientSlotTypeApi Client { get; }

        public SlotTypeApi(HttpClient client)
        {
            Client = RestService.For<IClientSlotTypeApi>(client, ManagementRefitSettings.Create());
        }

        public async Task<string> Create(string vendorId, string name, string description = null)
        {
            var response = await Client.Create(new CreateSlotRequest
            {
                VendorId = vendorId,
                SlotType = new SharedSlotType
                {
                    Name = name,
                    Description = description
                }
            });
            return response.SlotType.Id;
        }

        public async Task<SharedSlotType> Get(string slotId)
        {
            var response = await Client.Get(slotId);
            return response.SlotType;
        }
    }
}
