using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Requests.Accounts.TradingAcounts;

public class MTrCreateTradingAccountRequest
{
    [JsonPropertyName("offerUuid")]
    public string OfferId { get; set; }
    
    [JsonPropertyName("commissionUuid")]
    public string CommissionUuid { get; set; } = string.Empty;
}
