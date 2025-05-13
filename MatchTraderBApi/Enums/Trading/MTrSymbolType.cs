using System.Runtime.Serialization;

namespace MatchTraderBApi.Enums.Trading;

public enum MTrSymbolType
{
    [EnumMember(Value = "FOREX")]
    Forex,
    
    [EnumMember(Value = "CFD")]
    Cfd,
    
    [EnumMember(Value = "FOREX_CFD")]
    ForexCfd,
}