﻿using System;
using System.Threading.Tasks;
using VoicifyAlexa.NET.Management.Skills;

namespace VoicifyAlexa.NET.Management.SkillSets
{
    public class SkillSetContextSimulationApi : ISkillSetContextSimulationApi
    {
        private readonly ManagementApi _api;
        private readonly SkillSetLocale _locale;

        public SkillSetContextSimulationApi(ManagementApi api, SkillSetLocale locale)
        {
            _api = api;
            _locale = locale;
        }

        public Task<SimulationResponse> NewSession(string message)
        {
            return SendMessage(message, SimulationSession.ForceNewSession);
        }

        public Task<SimulationResponse> SendNextMessage(string message)
        {
            return SendMessage(message, SimulationSession.Default);
        }

        public async Task<SimulationResult> WaitForResult(SimulationResponse response, int pollSeconds)
        {
            while (response.Status == InvocationStatus.InProgress)
            {
                await Task.Delay(TimeSpan.FromSeconds(pollSeconds));
                response = await _api.Skills.SimulationResult(_locale.SkillID, _locale.Stage.Stage.Value,response.Id);
            }

            return response.Result;
        }

        private Task<SimulationResponse> SendMessage(string message, SimulationSession session)
        {
            return _api.Skills.Simulate(_locale.SkillID, _locale.Stage.Stage.Value, new SimulationRequest
            {
                Device = new SimulationRequestDevice
                {
                    Locale = _locale.Locale
                },
                Input = new SimulationRequestInput
                {
                    Content = message
                },
                Session = session
            });
        }
    }
}