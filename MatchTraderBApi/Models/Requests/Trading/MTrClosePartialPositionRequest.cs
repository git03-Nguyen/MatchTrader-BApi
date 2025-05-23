using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Requests.Trading;

public class MTrClosePartialPositionRequest
{
    [JsonPropertyName("systemUuid")]
    public string SystemUuid { get; set; }

    [JsonPropertyName("login")]
    public string Login { get; set; }

    [JsonPropertyName("positionId")]
    public string PositionId { get; set; }

    [JsonPropertyName("instrument")]
    public string Symbol { get; set; }

    [JsonPropertyName("volume")]
    public decimal Volume { get; set; }
}