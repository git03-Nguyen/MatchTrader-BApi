using System.Text.Json.Serialization;
using MatchTraderBApi.Models.Dtos;
using MatchTraderBApi.Models.Dtos.Trading;

namespace MatchTraderBApi.Models.Responses.Trading.TradingData;

public class MTrGetOpenPositionsResponse
{
    [JsonPropertyName("positions")]
    public List<MTrOpenPosition> Positions { get; set; }
}