using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.InteractionModel.ValidationRules
{
    public class IsNotInSet : DialogSlotValidation
    {
        public const string ValidationType = "isNotInSet";
        public override string Type => ValidationType;

        [JsonProperty("values")]
        public string[] Values { get; set; }
    }
}