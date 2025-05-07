using System.Runtime.Serialization;

namespace MatchTraderBApi.Enums.SortingFields;

public enum MTrBasicSortingField
{
    [EnumMember(Value = "created")]
    Created,
    
    [EnumMember(Value = "updated")]
    Updated,
}