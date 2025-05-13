using System.Net;
using System.Reflection;
using System.Runtime.Serialization;
using MatchTraderBApi.Enums;

namespace MatchTraderBApi.Extensions;

internal static class ConversionExtensions
{
    internal static string ToEnumString(this Enum enumValue)
    {
        var member = enumValue.GetType()
            .GetMember(enumValue.ToString())
            .FirstOrDefault();

        var attribute = member?.GetCustomAttribute<EnumMemberAttribute>();
        return attribute?.Value ?? enumValue.ToString();
    }

    internal static MTrRetCode ToMTrRetCode(this HttpStatusCode statusCode)
    {
        return statusCode switch
        {
            HttpStatusCode.OK => MTrRetCode.MTrRet200Ok,
            HttpStatusCode.NoContent => MTrRetCode.MTrRet204OkNone,
            HttpStatusCode.BadRequest => MTrRetCode.MTrRet400BadRequest,
            HttpStatusCode.Unauthorized => MTrRetCode.MTrRet401Unauthorized,
            HttpStatusCode.Forbidden => MTrRetCode.MTrRet403Forbidden,
            HttpStatusCode.MethodNotAllowed => MTrRetCode.MTrRet405WrongMethod,
            HttpStatusCode.UnprocessableEntity => MTrRetCode.MTrRet422Unprocessed,
            HttpStatusCode.InternalServerError => MTrRetCode.MTrRet500InternalError,
            HttpStatusCode.BadGateway => MTrRetCode.MTrRet502BadGateway,
            _ => throw new ArgumentOutOfRangeException(nameof(statusCode), $"Unexpected status code: {statusCode}")
        };
    }
}