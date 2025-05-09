using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Responses.General;

public class MTrGetServiceInfoResponse
{
    [JsonPropertyName("artifact")]
    public string Artifact { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("serviceVersion")]
    public string ServiceVersion { get; set; }
}

