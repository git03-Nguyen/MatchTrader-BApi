using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Requests.Trading.TradingData;

public class MTrRetrieveClosedPositionsByIdsRequest
{
    [JsonPropertyName("systemUuid")]
    public string SystemUuid { get; set; }

    [JsonPropertyName("login")]
    public string Login { get; set; }

    [JsonPropertyName("from")]
    public DateTime From { get; set; }

    [JsonPropertyName("to")]
    public DateTime To { get; set; }

    [JsonPropertyName("ids")]
    public List<string> PositionIds { get; set; }
}