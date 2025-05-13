using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos.Trading;

public class MTrClosedPosition
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("openTime")]
    public DateTime OpenTime { get; set; }

    [JsonPropertyName("openPrice")]
    public decimal OpenPrice { get; set; }

    [JsonPropertyName("symbol")]
    public string Symbol { get; set; }

    [JsonPropertyName("alias")]
    public string? Alias { get; set; }

    [JsonPropertyName("volume")]
    public decimal Volume { get; set; }

    [JsonPropertyName("stopLoss")]
    public decimal StopLoss { get; set; }

    [JsonPropertyName("takeProfit")]
    public decimal TakeProfit { get; set; }

    [JsonPropertyName("time")]
    public DateTime CloseTime { get; set; }

    [JsonPropertyName("closePrice")]
    public decimal ClosePrice { get; set; }

    [JsonPropertyName("commission")]
    public decimal Commission { get; set; }

    [JsonPropertyName("swap")]
    public decimal Swap { get; set; }

    [JsonPropertyName("profit")]
    public decimal Profit { get; set; }

    [JsonPropertyName("side")]
    public string Side { get; set; }

    [JsonPropertyName("netProfit")]
    public decimal NetProfit { get; set; }

    [JsonPropertyName("closingOrderID")]
    public string ClosingOrderId { get; set; }

    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    [JsonPropertyName("comment")]
    public string? Comment { get; set; }
}