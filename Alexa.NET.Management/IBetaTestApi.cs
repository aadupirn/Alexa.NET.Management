﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using VoicifyAlexa.NET.Management.Beta;
using VoicifyAlexa.NET.Management.Internals;
using Refit;

namespace VoicifyAlexa.NET.Management
{
    public interface IBetaTestApi
    {
        Task<Uri> Create(string skillId, string feedbackEmail);

        Task<BetaTest> Get(string skillId);

        Task<bool> Update(string skillId, string feedbackEmail);

        Task<bool> Start(string skillId);

        Task<bool> End(string skillId);

        Task<BetaTestersResponse> Testers(string skillId);

        Task<BetaTestersResponse> Testers(string skillId, int maxResults);

        Task<BetaTestersResponse> Testers(string skillId, int maxResults, string nextToken);

        Task<bool> AddTesters(string skillId, IEnumerable<string> emails);

        Task<bool> RemoveTesters(string skillId, IEnumerable<string> emails);

        Task<bool> SendReminders(string skillId, IEnumerable<string> emails);

        Task<bool> RequestFeedback(string skillId, IEnumerable<string> emails);

    }
}
