using System.Text.Json.Serialization;
using MatchTraderBApi.Models.Dtos.Account;

namespace MatchTraderBApi.Models.Responses.Account;

public class MTrGetAccountTimelineEventsResponse
{
    [JsonPropertyName("timelineEvents")]
    public List<MTrTimelineEvent> TimeLineEvents { get; set; } = [];
}