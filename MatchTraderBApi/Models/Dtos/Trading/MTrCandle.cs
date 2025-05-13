using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos.Trading;

public class MTrCandle
{
    [JsonPropertyName("time")]
    public long Time { get; set; }

    [JsonPropertyName("open")]
    public decimal Open { get; set; }

    [JsonPropertyName("high")]
    public decimal High { get; set; }

    [JsonPropertyName("low")]
    public decimal Low { get; set; }

    [JsonPropertyName("close")]
    public decimal Close { get; set; }
}