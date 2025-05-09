using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Responses.Account;

public class MTrAddAccountNoteResponse
{
    [JsonPropertyName("uuid")]
    public string Uuid { get; set; }
    
    [JsonPropertyName("created")]
    public string Created { get; set; }
    
    [JsonPropertyName("createdBy")]
    public string CreatedBy { get; set; }
    
    [JsonPropertyName("accountUuid")]
    public string AccountUuid { get; set; }
    
    [JsonPropertyName("type")]
    public string Type { get; set; }
    
    [JsonPropertyName("content")]
    public string Content { get; set; }
}
