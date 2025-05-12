using System.Runtime.Serialization;

namespace MatchTraderBApi.Enums;

public enum MTrSystemType
{
    [EnumMember(Value = "MT4")]
    MT4,
    
    [EnumMember(Value = "MT5")]
    MT5,
    
    [EnumMember(Value = "QFX")]
    QFX,
}