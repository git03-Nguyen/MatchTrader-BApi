using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos.Trading;

public class MTrOpenPosition : MTrPosition
{
    [JsonPropertyName("positions")]
    public List<MTrPosition> Positions { get; set; }
}