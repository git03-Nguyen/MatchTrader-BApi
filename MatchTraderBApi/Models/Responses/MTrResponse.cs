using MatchTraderBApi.Enums;

namespace MatchTraderBApi.Models.Responses;

public class MTrResponse<TResponseData>
{
    public MTrRetCode RetCode { get; set; }
    public TResponseData Data { get; set; }
}
