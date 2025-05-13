using System.Text.Json.Serialization;
using MatchTraderBApi.Enums.Account;

namespace MatchTraderBApi.Models.Requests.Accounts.TradingAcounts;

public class MTrUpdateTradingAccountRequest
{
    [JsonPropertyName("offerUuid")]
    public string? OfferUuid { get; set; }
    
    [JsonPropertyName("commissionUuid")]
    public string? CommissionUuid { get; set; }
    
    [JsonPropertyName("access")]
    public MTrTradingAccountAccess? Access { get; set; }
}
