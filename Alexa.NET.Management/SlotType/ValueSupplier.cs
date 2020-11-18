using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.SlotType
{
    [JsonConverter(typeof(ValueSupplierConverter))]
    public abstract class ValueSupplier
    {
        [JsonProperty("type")]
        public abstract string Type { get; }
    }
}