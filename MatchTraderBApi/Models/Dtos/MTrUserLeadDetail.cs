using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos;

public class MTrUserLeadDetail
{
    [JsonPropertyName("statusUuid")]
    public string StatusUuid { get; set; }

    [JsonPropertyName("source")]
    public string Source { get; set; }

    [JsonPropertyName("providerUuid")]
    public string? ProviderUuid { get; set; }

    [JsonPropertyName("becomeActiveClientTime")]
    public string BecomeActiveClientTime { get; set; }
}