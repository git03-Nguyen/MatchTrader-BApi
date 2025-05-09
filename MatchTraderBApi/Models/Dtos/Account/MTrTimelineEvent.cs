using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos.Account;

public class MTrTimelineEvent
{
    [JsonPropertyName("details")]
    public string Details { get; set; }
    
    [JsonPropertyName("event")]
    public string Event { get; set; }
    
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }
    
    [JsonPropertyName("created")]
    public string Created { get; set; }
}