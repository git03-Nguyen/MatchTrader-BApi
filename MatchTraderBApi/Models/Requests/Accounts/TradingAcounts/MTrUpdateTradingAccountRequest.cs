using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Requests.Accounts.TradingAcounts;

public class MTrUpdateTradingAccountRequest
{
    [JsonPropertyName("offerUuid")]
    public string OfferUuid { get; set; }
    
    [JsonPropertyName("commissionUuid")]
    public string CommissionUuid { get; set; } = string.Empty;
    
    [JsonPropertyName("access")]
    public string Access { get; set; } = string.Empty;
}
