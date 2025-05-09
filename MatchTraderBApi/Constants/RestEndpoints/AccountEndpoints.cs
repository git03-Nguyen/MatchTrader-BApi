using MatchTraderBApi.Enums;
using MatchTraderBApi.Enums.SortingFields;
using MatchTraderBApi.Extensions;

namespace MatchTraderBApi.Constants.RestEndpoints;

internal static class AccountEndpoints
{
    internal static string GetAccounts(
        string? query, int? page, int? size, DateTime? from, DateTime? to, MTrAccountType? accountType, MTrAccountSortingField? sortField, MTrSortingOrder? sortingOrder)
        => "/v1/accounts" +
           $"?query={query}" +
           $"&page={page.ToString()}" +
           $"&size={size.ToString()}" +
           $"&from={from.ToString()}" +
           $"&to={to.ToString()}" +
           $"&accountType={accountType?.ToEnumString()}" +
           $"&sort={string.Join(',', sortField?.ToEnumString(), sortingOrder?.ToEnumString())}";
    
    internal static string GetAccountByEmail(string email) => $"/v1/accounts/by-email/{email}";
    internal static string GetAccountByUuid(string accountUuid) => $"/v1/accounts/by-uuid/{accountUuid}";
    
    internal static string GetAccountTimelineEvents(string accountUuid, MTrAccountTimelineEventType? eventType, DateTime? from, DateTime? to, MTrBasicSortingField? sortField, MTrSortingOrder? sortOrder)
        => $"/v1/accounts/{accountUuid}/timeline-events" +
           $"?eventType={eventType?.ToEnumString()}" +
           $"&from={from.ToString()}" +
           $"&to={to.ToString()}" +
           $"&sort={string.Join(',', sortField?.ToEnumString(), sortOrder?.ToEnumString())}";
    
    internal static string CreateAccount() => "/v1/accounts";
    internal static string UpdateAccountInfo(string accountUuid) => $"/v1/accounts/{accountUuid}";
    internal static string ChangeAccountPassword() => "/v1/change-password";
    internal static string AddNote() => "/v1/note";
    internal static string AddTask() => "/v1/task";
}