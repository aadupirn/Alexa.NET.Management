﻿using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.CatalogManagement
{
    public class UploadCompleteRequest
    {
        public UploadCompleteRequest() { }

        public UploadCompleteRequest(params ETagPart[] parts)
        {
            PartETags = parts;
        }

        [JsonProperty("partETags")]
        public ETagPart[] PartETags { get; set; }
    }
}
