using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.InteractionModel.ValidationRules
{
    public class IsLessThanOrEqualTo : DialogSlotValidation
    {
        public const string ValidationType = "isLessThanOrEqualTo";
        public override string Type => ValidationType;

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}