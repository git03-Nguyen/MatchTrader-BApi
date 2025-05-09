using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos.Trading;

public class MTrClosePositionData
{
    [JsonPropertyName("positionId")]
    public string PositionId { get; set; }

    [JsonPropertyName("instrument")]
    public string Instrument { get; set; }
}