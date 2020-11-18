using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.InteractionModel.ValidationRules
{
    public class IsInSet : DialogSlotValidation
    {
        public const string ValidationType = "isInSet";
        public override string Type => ValidationType;

        [JsonProperty("values")]
        public string[] Values { get; set; }
    }
}