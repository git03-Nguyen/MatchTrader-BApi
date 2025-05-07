using System.Runtime.Serialization;

namespace MatchTraderBApi.Enums;

public enum MTrCandleInterval
{
    [EnumMember(Value = "M1")]
    M1,
    
    [EnumMember(Value = "M5")]
    M5,
    
    [EnumMember(Value = "M15")]
    M15,
    
    [EnumMember(Value = "M30")]
    M30,
    
    [EnumMember(Value = "H1")]
    H1,
    
    [EnumMember(Value = "H4")]
    H4,
    
    [EnumMember(Value = "D1")]
    D1,
    
    [EnumMember(Value = "W1")]
    W1,
    
    [EnumMember(Value = "MN1")]
    Mn1
}
