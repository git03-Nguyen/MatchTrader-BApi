using System.Text.Json.Serialization;
using MatchTraderBApi.Models.Dtos.General;

namespace MatchTraderBApi.Models.Responses.General;

public class MTrGetOffersResponse
{
    [JsonPropertyName("offers")]
    public List<MTrOffer> Offers { get; set; } = [];
}