using System.Runtime.Serialization;

namespace MatchTraderBApi.Enums.Trading;

public enum MTrOrderSide
{
    [EnumMember(Value = "BUY")]
    Buy,
     
    [EnumMember(Value = "SELL")]
    Sell,
}