using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos.Trading;

public class MTrClosePosition
{
    [JsonPropertyName("time")]
    public string Time { get; set; }

    [JsonPropertyName("closePrice")]
    public decimal? ClosePrice { get; set; }

    [JsonPropertyName("closingOrderID")]
    public string ClosingOrderId { get; set; }

    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    [JsonPropertyName("comment")]
    public string Comment { get; set; }
}