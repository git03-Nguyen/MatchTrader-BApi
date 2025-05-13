using System.Text.Json.Serialization;
using MatchTraderBApi.Enums;
using MatchTraderBApi.Models.Dtos.Trading;

namespace MatchTraderBApi.Models.Responses.Trading.TradingData.Candle;

public class MTrGetCandlesResponse
{
    [JsonPropertyName("symbol")]
    public string Symbol { get; set; }

    [JsonPropertyName("interval")]
    public MTrCandleInterval Interval { get; set; }

    [JsonPropertyName("candles")]
    public List<MTrCandle> Candles { get; set; }
}