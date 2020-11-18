﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using VoicifyAlexa.NET.Management.IntentRequestHistory;
using Refit;

namespace VoicifyAlexa.NET.Management.Internals
{
    internal class IntentRequestHistoryApi:IIntentRequestHistoryApi
    {
        public IntentRequestHistoryApi(HttpClient httpClient)
        {
            Client = RestService.For<IClientIntentRequestHistoryApi>(httpClient, ManagementRefitSettings.Create());
        }

        public IClientIntentRequestHistoryApi Client { get; set; }

        public Task<IntentRequestHistoryResponse> Get(string skillId, IntentRequestHistoryRequest request)
        {
            return Client.Get(skillId, new ClientIntentRequestHistoryRequest(request));
        }
    }
}
