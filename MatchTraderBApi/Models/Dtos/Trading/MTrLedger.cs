using System.Text.Json.Serialization;
using MatchTraderBApi.Enums;

namespace MatchTraderBApi.Models.Dtos.Trading;

public class MTrLedger
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    [JsonPropertyName("type")]
    public MTrLedgerType Type { get; set; }

    [JsonPropertyName("time")]
    public DateTime Time { get; set; }

    [JsonPropertyName("profit")]
    public decimal? Profit { get; set; }

    [JsonPropertyName("comment")]
    public string Comment { get; set; }
}