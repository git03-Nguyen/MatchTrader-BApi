using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos;

public class MTrOrder
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("creationTime")]
    public string CreationTime { get; set; }

    [JsonPropertyName("activationPrice")]
    public decimal? ActivationPrice { get; set; }

    [JsonPropertyName("side")]
    public string Side { get; set; }

    [JsonPropertyName("comment")]
    public string Comment { get; set; }
}