using System.Text.Json.Serialization;
using MatchTraderBApi.Enums.Account;

namespace MatchTraderBApi.Models.Responses.Account;

public class MTrAddAccountNoteResponse
{
    [JsonPropertyName("uuid")]
    public string Uuid { get; set; }
    
    [JsonPropertyName("created")]
    public DateTime Created { get; set; }
    
    [JsonPropertyName("createdBy")]
    public string CreatedBy { get; set; }
    
    [JsonPropertyName("accountUuid")]
    public string AccountUuid { get; set; }
    
    [JsonPropertyName("type")]
    public MTrTaskType Type { get; set; }
    
    [JsonPropertyName("content")]
    public string Content { get; set; }
}
