using System.Text.Json.Serialization;
using MatchTraderBApi.Models.Dtos.Trading;

namespace MatchTraderBApi.Models.Responses.Trading.TradingData;

public class MTrGetLedgersResponse
{
    [JsonPropertyName("operations")]
    public List<MTrLedger> Operations { get; set; }
}