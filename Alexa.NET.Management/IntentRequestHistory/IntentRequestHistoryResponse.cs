using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.IntentRequestHistory
{
	public class IntentRequestHistoryResponse{
		[JsonProperty("body")]
		public IntentRequestHistoryResponseBody Body { get; set; }
	}
}
