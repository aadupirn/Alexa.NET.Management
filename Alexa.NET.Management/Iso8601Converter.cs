using Newtonsoft.Json.Converters;

namespace VoicifyAlexa.NET.Management
{
    internal class Iso8601Converter:IsoDateTimeConverter
    {
        public Iso8601Converter()
        {
            DateTimeFormat = "yyyy-MM-ddTHH:mm:ss.fffZ";
        }
    }
}