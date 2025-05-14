using System.Text.Json.Serialization;
using MatchTraderBApi.Models.Dtos.Trading;

namespace MatchTraderBApi.Models.Responses.Trading.TradingData;

public class MTrRetrieveOrdersHistoryByLoginsOrGroupsResponse
{
    [JsonPropertyName("login")]
    public string Login { get; set; }

    [JsonPropertyName("group")]
    public string Group { get; set; }

    [JsonPropertyName("historicalOrders")]
    public List<MTrOrderHistory> Orders { get; set; }
}