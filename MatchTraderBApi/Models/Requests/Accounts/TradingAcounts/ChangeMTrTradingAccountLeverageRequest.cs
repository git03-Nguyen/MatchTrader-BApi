using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Requests.Accounts.TradingAcounts;

public class ChangeMTrTradingAccountLeverageRequest
{
    [JsonPropertyName("leverage")]
    public string Leverage { get; set; }
}
