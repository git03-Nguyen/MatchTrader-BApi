using System.Text.Json.Serialization;
using MatchTraderBApi.Models.Dtos;

namespace MatchTraderBApi.Models.Responses.Trading.TradingData;

public class RetrieveMTrLedgersByLoginsOrGroupsResponse
{
    [JsonPropertyName("login")]
    public string Login { get; set; }
    
    [JsonPropertyName("group")]
    public string Group { get; set; }
    
    [JsonPropertyName("operations")]
    public List<MTrLedger> Operations { get; set; }
}