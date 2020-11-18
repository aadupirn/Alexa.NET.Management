using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace VoicifyAlexa.NET.Management.CatalogManagement
{
    public class UploadFile
    {
        [JsonProperty("presignedDownloadUrl")]
        public Uri PresignedDownloadUrl { get; set; }

        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public UploadFileStatus Status { get; set; }
    }
}