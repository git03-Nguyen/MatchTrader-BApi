using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos.General;

public class MTrRole
{
    [JsonPropertyName("uuid")]
    public string Uuid { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("partnerId")]
    public long? PartnerId { get; set; }
    
    [JsonPropertyName("created")]
    public string created { get; set; }
    
    [JsonPropertyName("updated")]
    public string updated { get; set; }
}