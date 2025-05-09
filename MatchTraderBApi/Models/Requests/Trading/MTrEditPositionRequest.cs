using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Requests.Trading;

public class MTrEditPositionRequest
{
    [JsonPropertyName("systemUuid")]
    public string SystemUuid { get; set; }

    [JsonPropertyName("login")]
    public string Login { get; set; }

    [JsonPropertyName("id")]
    public string PositionId { get; set; }

    [JsonPropertyName("slPrice")]
    public decimal? SLPrice { get; set; }

    [JsonPropertyName("tpPrice")]
    public decimal? TPPrice { get; set; }
}