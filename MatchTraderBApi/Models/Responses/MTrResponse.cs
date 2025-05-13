using MatchTraderBApi.Enums;

namespace MatchTraderBApi.Models.Responses;

public class MTrResponse<TResponseData>
{
    public MTrRetCode RetCode { get; set; }
    public string RetMessage { get; set; }
    public TResponseData RetData { get; set; }
}