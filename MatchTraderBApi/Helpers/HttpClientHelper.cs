using System.Text.Json;
using System.Text.Json.Serialization;

namespace MatchTraderBApi.Helpers;

public static class HttpClientHelper
{
    private static readonly JsonSerializerOptions JsonSerializerOptions = new()
    {
        Converters = { new JsonStringEnumConverter() }
    };
}