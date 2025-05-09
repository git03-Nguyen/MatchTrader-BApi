using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos.Trading;

public class MTrTradingHour
{
    [JsonPropertyName("dayNumber")]
    public int? DayNumber { get; set; }

    [JsonPropertyName("openHours")]
    public int? OpenHours { get; set; }

    [JsonPropertyName("openMinutes")]
    public int? OpenMinutes { get; set; }

    [JsonPropertyName("openSeconds")]
    public int? OpenSeconds { get; set; }

    [JsonPropertyName("closeHours")]
    public int? CloseHours { get; set; }

    [JsonPropertyName("closeMinutes")]
    public int? CloseMinutes { get; set; }

    [JsonPropertyName("closeSeconds")]
    public int? CloseSeconds { get; set; }
}