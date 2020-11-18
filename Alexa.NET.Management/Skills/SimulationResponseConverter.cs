using System;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace VoicifyAlexa.NET.Management.Skills
{
    public class SimulationResponseConverter:JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jObject = JObject.Load(reader);

            var type = jObject["type"].Value<string>();
            object target = type switch
            {
                SimulationSpeechResponse.ResponseType => new SimulationSpeechResponse(),
                _ => throw new InvalidOperationException("Unknown simulation response type: " + type)
            };

            serializer.Populate(jObject.CreateReader(), target);

            return target;
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(SimulationAlexaResponse).IsAssignableFrom(objectType);
        }

        public override bool CanWrite => false;
    }
}