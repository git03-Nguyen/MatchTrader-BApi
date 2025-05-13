using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Requests.Accounts.TradingAcounts;

public class MTrChangeTradingAccountLeverageRequest
{
    [JsonPropertyName("leverage")]
    public uint Leverage { get; set; }
}
