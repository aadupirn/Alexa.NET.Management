using VoicifyAlexa.NET.Management.Api;
using VoicifyAlexa.NET.Management.Skills;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.IntentRequestHistory
{
    public class IntentRequestHistoryItem
    {
        [JsonProperty("dialogAct")]
        public DialogAction DialogAction { get; set; }

        [JsonProperty("intent")]
        public IntentInformation IntentInformation { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("interactionType")]
        public InteractionType InteractionType { get; set; }

        [JsonProperty("stage")]
        public SkillStage Stage { get; set; }

        [JsonProperty("publicationStatus")]
        public PublicationStatus PublicationStatus { get; set; }

        [JsonProperty("utteranceText")]
        public string UtteranceText { get; set; }
    }
}