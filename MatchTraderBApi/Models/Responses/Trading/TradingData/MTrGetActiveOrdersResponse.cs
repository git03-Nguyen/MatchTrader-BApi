using System.Text.Json.Serialization;
using MatchTraderBApi.Models.Dtos.Trading;

namespace MatchTraderBApi.Models.Responses.Trading.TradingData;

public class MTrGetActiveOrdersResponse
{
    [JsonPropertyName("orders")]
    public IEnumerable<MTrOrder> Orders { get; set; }
}