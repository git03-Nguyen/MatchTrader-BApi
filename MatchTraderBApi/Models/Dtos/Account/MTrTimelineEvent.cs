using System.Text.Json.Serialization;
using MatchTraderBApi.Enums;

namespace MatchTraderBApi.Models.Dtos.Account;

public class MTrTimelineEvent
{
    [JsonPropertyName("details")]
    public string? Details { get; set; }
    
    [JsonPropertyName("event")]
    public MTrAccountTimelineEventType? Event { get; set; }
    
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }
    
    [JsonPropertyName("created")]
    public DateTime? Created { get; set; }
}