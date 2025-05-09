using System.Text.Json.Serialization;
using MatchTraderBApi.Models.Dtos;

namespace MatchTraderBApi.Models.Responses.Trading.TradingData;

public class RetrieveMTrOrderHistoryByLoginsOrGroupsResponse
{
    [JsonPropertyName("login")]
    public string Login { get; set; }
    
    [JsonPropertyName("group")]
    public string Group { get; set; }
    
    [JsonPropertyName("historicalOrders")]
    public List<MTrOrderHistory> HistoricalOrders { get; set; }
}