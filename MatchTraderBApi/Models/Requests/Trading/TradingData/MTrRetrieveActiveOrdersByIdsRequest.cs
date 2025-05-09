using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Requests.Trading.TradingData;

public class MTrRetrieveActiveOrdersByIdsRequest
{
    [JsonPropertyName("systemUuid")]
    public string SystemUuid { get; set; }

    [JsonPropertyName("login")]
    public string Login { get; set; }

    [JsonPropertyName("ids")]
    public List<string> OrderIds { get; set; }
}