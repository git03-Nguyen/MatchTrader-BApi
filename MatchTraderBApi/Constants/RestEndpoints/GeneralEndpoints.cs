using MatchTraderBApi.Enums;
using MatchTraderBApi.Enums.SortingFields;
using MatchTraderBApi.Extensions;

namespace MatchTraderBApi.Constants.RestEndpoints;

public static class GeneralEndpoints
{
    public static string ServiceInfo() => "/service-info";
    
    public static string GetBranches(DateTime? from, DateTime? to, MTrBasicSortingField? sortField, MTrSortingOrder? sortOrder) => "/v1/branches" +
        $"?from={from.ToString()}" +
        $"&to={to.ToString()}" +
        $"&sort={string.Join(',', sortField?.ToEnumString(), sortOrder?.ToEnumString())}";
    
    public static string GetOffers(DateTime? from, DateTime? to, MTrBasicSortingField? sortField, MTrSortingOrder? sortOrder) => "/v1/offers" +
        $"?from={from.ToString()}" +
        $"&to={to.ToString()}" +
        $"&sort={string.Join(',', sortField?.ToEnumString(), sortOrder?.ToEnumString())}";
    
    public static string GetRoles(DateTime? from, DateTime? to, MTrBasicSortingField? sortField, MTrSortingOrder? sortOrder) => "/v1/roles" +
        $"?from={from.ToString()}" +
        $"&to={to.ToString()}" +
        $"&sort={string.Join(',', sortField?.ToEnumString(), sortOrder?.ToEnumString())}";
    
    public static string RetrievePlatformLogsV2(int? page, int? size, DateTime? from, DateTime? to, MTrSortingOrder? sortOrder) => "/v2/platform-logs" +
        $"?page={page.ToString()}" +
        $"&size={size.ToString()}" +
        $"&from={from.ToString()}" +
        $"&to={to.ToString()}" +
        $"&sort={sortOrder?.ToEnumString()}";
}