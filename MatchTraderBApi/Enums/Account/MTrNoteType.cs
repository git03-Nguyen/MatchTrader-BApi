using System.Runtime.Serialization;

namespace MatchTraderBApi.Enums.Account;

public enum MTrNoteType
{
    [EnumMember(Value = "CALL")]
    Call,
    
    [EnumMember(Value = "NOTE")]
    Note
}