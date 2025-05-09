using System.Text.Json.Serialization;
using MatchTraderBApi.Models.Dtos;
using MatchTraderBApi.Models.Dtos.Trading;

namespace MatchTraderBApi.Models.Responses.Trading.TradingData;

public class MTrGetLedgerResponse
{
    [JsonPropertyName("operations")]
    public List<MTrLedger> Operrations { get; set; }
}