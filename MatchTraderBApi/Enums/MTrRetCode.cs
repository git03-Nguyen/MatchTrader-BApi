namespace MatchTraderBApi.Enums;

public enum MTrRetCode
{
    MTrRet200Ok = 200,
    MTrRet204OkNone = 204,
    MTrRet400BadRequest = 400,
    MTrRet401Unauthorized = 401,
    MTrRet403Forbidden = 403,
    MTrRet405WrongMethod = 405,
    MTrRet422Unprocessed = 422,
    MTrRet500InternalError = 500,
}