using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Requests.Trading;

public class CloseAllMTrPositionsForTradingAccountsRequest
{
    [JsonPropertyName("systemUuid")]
    public string SystemUuid { get; set; }

    [JsonPropertyName("logins")]
    public List<string> Logins { get; set; }
}