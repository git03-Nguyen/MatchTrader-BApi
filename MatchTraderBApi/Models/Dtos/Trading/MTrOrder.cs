using System.Text.Json.Serialization;
using MatchTraderBApi.Enums.Trading;

namespace MatchTraderBApi.Models.Dtos.Trading;

public class MTrOrder
{
    [JsonPropertyName("type")]
    public MTrOrderType Type { get; set; }

    [JsonPropertyName("creationTime")]
    public DateTime CreationTime { get; set; }

    [JsonPropertyName("activationPrice")]
    public decimal? ActivationPrice { get; set; }

    [JsonPropertyName("side")]
    public MTrOrderSide Side { get; set; }

    [JsonPropertyName("comment")]
    public string Comment { get; set; }
}