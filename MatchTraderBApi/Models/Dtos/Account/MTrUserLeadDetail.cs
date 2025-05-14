using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos.Account;

public class MTrUserLeadDetail
{
    [JsonPropertyName("statusUuid")]
    public string? StatusUuid { get; set; }

    [JsonPropertyName("source")]
    public string? Source { get; set; }

    [JsonPropertyName("providerUuid")]
    public string? ProviderUuid { get; set; }

    [JsonPropertyName("becomeActiveClientTime")]
    public DateTime? BecomeActiveClientTime { get; set; }
    
    public MTrUserLeadDetail(string? statusUuid, string? source, string? providerUuid, DateTimeOffset? becomeActiveClientTime)
    {
        StatusUuid = statusUuid;
        Source = source;
        ProviderUuid = providerUuid;
        BecomeActiveClientTime = becomeActiveClientTime?.UtcDateTime;
    }
}