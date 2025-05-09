using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos.Account;

public class MTrUserLeadDetailForUpdate
{
    [JsonPropertyName("leadStatusUuid")]
    public string LeadStatusUuid { get; set; }
}