using System.Text.Json.Serialization;
using MatchTraderBApi.Models.Dtos;

namespace MatchTraderBApi.Models.Responses.Trading.TradingData.Candles;

public class GetMTrCandlesResponse
{
    [JsonPropertyName("symbol")]
    public string Symbol { get; set; }

    [JsonPropertyName("interval")]
    public string Interval { get; set; }

    [JsonPropertyName("candles")]
    public List<MTrCandle> Candles { get; set; }
}