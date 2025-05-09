using System.Text.Json.Serialization;
using MatchTraderBApi.Models.Dtos;

namespace MatchTraderBApi.Models.Responses.Trading.TradingData;

public class RetrieveMTrOpenPositionsByIdsResponse
{
    [JsonPropertyName("positions")]
    public List<MTrOpenPosition> Positions { get; set; }
}