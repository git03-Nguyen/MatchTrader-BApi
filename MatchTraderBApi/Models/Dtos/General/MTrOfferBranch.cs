using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos.General;

public class MTrOfferBranch
{
    [JsonPropertyName("uuid")]
    public string Uuid { get; set; }

    [JsonPropertyName("partnerId")]
    public long? PartnerId { get; set; }

    [JsonPropertyName("created")]
    public DateTime Created { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}