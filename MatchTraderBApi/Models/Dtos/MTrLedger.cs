using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos;

public class MTrLedger
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("time")]
    public string Time { get; set; }

    [JsonPropertyName("profit")]
    public decimal? Profit { get; set; }

    [JsonPropertyName("comment")]
    public string Comment { get; set; }
}