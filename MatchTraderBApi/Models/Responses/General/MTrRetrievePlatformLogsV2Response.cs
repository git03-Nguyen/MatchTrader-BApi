using System.Text.Json.Serialization;
using MatchTraderBApi.Models.Dtos.Trading;

namespace MatchTraderBApi.Models.Responses.General;

public class MTrRetrievePlatformLogsV2Response
{
    [JsonPropertyName("content")]
    public List<object> content { get; set; }
    
    [JsonPropertyName("totalElements")]
    public long TotalElements { get; set; }
    
    [JsonPropertyName("totalPages")]
    public int TotalPages { get; set; }
    
    [JsonPropertyName("number")]
    public int Number { get; set; }
    
    [JsonPropertyName("size")]
    public int Size { get; set; }
}
