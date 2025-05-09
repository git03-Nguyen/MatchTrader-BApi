using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Requests.Trading;

public class CloseMTrPositionsRequest
{
    [JsonPropertyName("systemUuid")]
    public string SystemUuid { get; set; }

    [JsonPropertyName("login")]
    public string Login { get; set; }

    [JsonPropertyName("closePositions")]
    public List<CloseMTrPositionData> ClosePositions { get; set; }
}

public class CloseMTrPositionData
{
    [JsonPropertyName("positionId")]
    public string PositionId { get; set; }

    [JsonPropertyName("instrument")]
    public string Instrument { get; set; }
}