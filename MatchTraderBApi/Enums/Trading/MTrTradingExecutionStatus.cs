using System.Runtime.Serialization;

namespace MatchTraderBApi.Enums.Trading;

public enum MTrTradingExecutionStatus
{
    [EnumMember(Value = "OK")]
    Ok,
    
    [EnumMember(Value = "REJECTED")]
    Rejected,
    
    [EnumMember(Value = "PARTIAL_SUCCESS")]
    PartialSuccess,
    
    
    
}
