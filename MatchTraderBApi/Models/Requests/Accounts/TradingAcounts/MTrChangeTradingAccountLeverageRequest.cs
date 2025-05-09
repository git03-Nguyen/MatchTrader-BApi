using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Requests.Accounts.TradingAcounts;

public class MTrChangeTradingAccountLeverageRequest
{
    [JsonPropertyName("leverage")]
    public int Leverage { get; set; }
}
