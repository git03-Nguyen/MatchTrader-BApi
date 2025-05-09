using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Responses.Accounts;

public class GetMTrAccountTimelineEventsResponse
{
    [JsonPropertyName("timelineEvents")]
    public List<TimelineEvent> TimeLineEvents { get; set; }
}

public class TimelineEvent
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
