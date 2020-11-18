﻿using System.Runtime.Serialization;

namespace VoicifyAlexa.NET.Management.Skills
{
    public enum CertificationStatus
    {
        [EnumMember(Value = "IN_PROGRESS")] InProgress,
        [EnumMember(Value = "SUCCEEDED")] Succeeded,
        [EnumMember(Value = "FAILED")] Failed,
        [EnumMember(Value = "CANCELLED")] Cancelled
    }
}