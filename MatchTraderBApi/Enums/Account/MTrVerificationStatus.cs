using System.Runtime.Serialization;

namespace MatchTraderBApi.Enums.Account;

public enum MTrVerificationStatus
{
    [EnumMember(Value = "NEW")]
    New,
    
    [EnumMember(Value = "REJECTED")]
    Rejected,
    
    [EnumMember(Value = "VERIFIED")]
    Verified,
    
    [EnumMember(Value = "BLOCKED")]
    Blocked,
    
    [EnumMember(Value = "PENDING_VERIFICATION")]
    PendingVerification,
    
    [EnumMember(Value = "UNVERIFIED")]
    Unverified,
}