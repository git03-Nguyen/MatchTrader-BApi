using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos.Trading;

public class MTrOpenPosition
{
    [JsonPropertyName("positions")]
    public List<MTrPosition> Positions { get; set; }
}