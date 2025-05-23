using System.Text.Json.Serialization;
using MatchTraderBApi.Models.Dtos.Trading;

namespace MatchTraderBApi.Models.Responses.Trading.TradingData;

public class MTrGetClosedPositionsResponse
{
    [JsonPropertyName("closedPositions")]
    public List<MTrClosedPosition> ClosedPositions { get; set; }
}