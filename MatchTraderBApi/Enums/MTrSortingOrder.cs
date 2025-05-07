using System.Runtime.Serialization;

namespace MatchTraderBApi.Enums;

public enum MTrSortingOrder
{
    [EnumMember(Value = "asc")]
    Asc,
    
    [EnumMember(Value = "desc")]
    Desc
}