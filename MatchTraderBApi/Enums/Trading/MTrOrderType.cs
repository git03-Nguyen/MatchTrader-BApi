using System.Runtime.Serialization;

namespace MatchTraderBApi.Enums.Trading;

public enum MTrOrderType
{
    [EnumMember(Value = "LIMIT")]
    Limit,
     
    [EnumMember(Value = "STOP")]
    Stop,
    
    [EnumMember(Value = "UNTYPE")]
    UnType,
}