using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Requests.Accounts;

public class CreateMTrAccountNoteRequest
{
    [JsonPropertyName("accountUuid")]
    public string AccountUuid { get; set; }
    
    [JsonPropertyName("type")]
    public string Type { get; set; }
    
    [JsonPropertyName("content")]
    public string Content { get; set; }
}