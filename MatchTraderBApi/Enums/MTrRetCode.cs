namespace MatchTraderBApi.Enums;

public enum MTrRetCode
{
    MTrRet200Ok,
    MTrRet204OkNone,
    MTrRet400BadRequest,
    MTrRet401Unauthorized,
    MTrRet403Forbidden,
    MTrRet405WrongMethod,
    MTrRet422Unprocessed,
    MTrRet500InternalError
}