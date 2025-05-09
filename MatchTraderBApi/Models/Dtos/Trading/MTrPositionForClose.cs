using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos.Trading;

public class MTrPositionForClose
{
    [JsonPropertyName("positionId")]
    public string Id { get; set; }

    [JsonPropertyName("instrument")]
    public string Symbol { get; set; }
}