using System.Runtime.Serialization;

namespace MatchTraderBApi.Enums.Account;

public enum MTrTradingAccountAccess
{
    [EnumMember(Value = "FULL")]
    Full,
    
    [EnumMember(Value = "CLOSE_ONLY")]
    CloseOnly,
    
    [EnumMember(Value = "TRADING_DISABLED")]
    TradingDisabled,
    
    [EnumMember(Value = "TRADING_AND_LOGIN_DISABLED")]
    TradingAndLoginDisabled,
}