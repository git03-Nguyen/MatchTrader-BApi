using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Requests.Trading;

public class MTrCloseAllPositionsRequest
{
    [JsonPropertyName("systemUuid")]
    public string SystemUuid { get; set; }

    [JsonPropertyName("logins")]
    public IEnumerable<string> Logins { get; set; }
}