using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.ReferenceCatalogManagement
{
    public class ReferenceCatalogVersionUpdate
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
