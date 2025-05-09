using System.Text.Json.Serialization;
using MatchTraderBApi.Models.Dtos;
using MatchTraderBApi.Models.Dtos.Trading;

namespace MatchTraderBApi.Models.Responses.Trading.TradingData;

public class MTrGetClosedPositionsResponse
{
    [JsonPropertyName("closedPositions")]
    public List<MTrClosePosition> ClosedPositions { get; set; }
}