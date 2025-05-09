using System.Runtime.Serialization;

namespace MatchTraderBApi.Enums.Trading;

public enum MTrOrderStatus
{
    [EnumMember(Value = "FILLED")]
    Filled,
    
    [EnumMember(Value = "CANCELLED")]
    Cancelled,
    
    [EnumMember(Value = "REJECTED")]
    Rejected,
    
    [EnumMember(Value = "ADDED")]
    Added,
    
    [EnumMember(Value = "ACTIVE_ORDER_PRICE_EDITED")]
    ActiveOrderPriceEdited,
}