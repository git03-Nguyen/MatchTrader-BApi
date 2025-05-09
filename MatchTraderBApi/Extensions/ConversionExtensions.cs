using System.Reflection;
using System.Runtime.Serialization;

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
}