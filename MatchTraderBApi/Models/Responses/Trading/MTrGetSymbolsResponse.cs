using System.Text.Json.Serialization;
using MatchTraderBApi.Models.Dtos.Trading;

namespace MatchTraderBApi.Models.Responses.Trading;

public class MTrGetSymbolsResponse
{
    [JsonPropertyName("effectiveInstruments")]
    public List<MTrSymbol> EffectiveSymbols { get; set; }
}