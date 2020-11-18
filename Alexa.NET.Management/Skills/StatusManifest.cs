﻿using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Skills
{
    public class StatusManifest
    {
        [JsonProperty("lastUpdateRequest")]
        public LastModifiedInformation LastModified { get; set; }

        [JsonProperty("errors")]
        public InvocationError[] Errors { get; set; }

        [JsonProperty("eTag")]
        public string Etag { get; set; }
    }
}