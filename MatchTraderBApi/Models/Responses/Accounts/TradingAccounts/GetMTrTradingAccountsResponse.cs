using System.Text.Json.Serialization;
using MatchTraderBApi.Models.Dtos;

namespace MatchTraderBApi.Models.Responses.Accounts.TradingAccounts;

public class GetMTrTradingAccountsResponse
{
    [JsonPropertyName("content")]
    public List<MTrTradingAccount> Content { get; set; }
    
    [JsonPropertyName("totalPages")]
    public int TotalPages { get; set; }
    
    [JsonPropertyName("totalElements")]
    public int TotalElements { get; set; }
    
    [JsonPropertyName("number")]
    public int? Number { get; set; }
    
    [JsonPropertyName("size")]
    public int Size { get; set; }
}
