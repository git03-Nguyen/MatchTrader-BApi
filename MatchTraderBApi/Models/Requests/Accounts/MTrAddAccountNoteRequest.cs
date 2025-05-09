using System.Text.Json.Serialization;
using MatchTraderBApi.Enums.Account;

namespace MatchTraderBApi.Models.Requests.Accounts;

public class MTrAddAccountNoteRequest
{
    [JsonPropertyName("accountUuid")]
    public string AccountUuid { get; set; }
    
    [JsonPropertyName("type")]
    public MTrNoteType Type { get; set; }
    
    [JsonPropertyName("content")]
    public string Content { get; set; }
}