using System.Text.Json.Serialization;
using MatchTraderBApi.Models.Dtos;

namespace MatchTraderBApi.Models.Responses.Trading.TradingData;

public class GetMTrActiveOrdersResponse
{
    [JsonPropertyName("orders")]
    public List<MTrOrder> Orders { get; set; }
}