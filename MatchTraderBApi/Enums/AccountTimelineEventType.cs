using System.Runtime.Serialization;

namespace MatchTraderBApi.Enums;

public enum AccountTimelineEventType
{
    [EnumMember(Value = "VOIP_CALL")]
    VoIPCall,

    [EnumMember(Value = "NOTE")]
    Note,

    [EnumMember(Value = "TASK_CALL")]
    TaskCall,

    [EnumMember(Value = "TASK")]
    Task,

    [EnumMember(Value = "LEAD_ASSIGNMENT")]
    LeadAssignment,

    [EnumMember(Value = "FAILED_DEPOSIT")]
    FailedDeposit,

    [EnumMember(Value = "SUCCESSFUL_DEPOSIT")]
    SuccessfulDeposit,

    [EnumMember(Value = "WITHDRAWAL_TO_CONFIRM")]
    WithdrawalToConfirm,

    [EnumMember(Value = "STOP_LOSS")]
    StopLoss,

    [EnumMember(Value = "TAKE_PROFIT")]
    TakeProfit,

    [EnumMember(Value = "ORDER_ACTIVATION")]
    OrderActivation,

    [EnumMember(Value = "STOP_OUT")]
    StopOut,

    [EnumMember(Value = "MARGIN_CALL")]
    MarginCall,

    [EnumMember(Value = "LOGIN")]
    Login
}