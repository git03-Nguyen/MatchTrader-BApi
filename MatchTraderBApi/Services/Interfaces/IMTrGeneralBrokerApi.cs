using MatchTraderBApi.Enums;
using MatchTraderBApi.Enums.SortingFields;
using MatchTraderBApi.Models.Requests.General;
using MatchTraderBApi.Models.Responses;
using MatchTraderBApi.Models.Responses.General;

namespace MatchTraderBApi.Services.Interfaces;

public interface IMTrGeneralBrokerApi
{
    Task<MTrResponse<MTrGetServiceInfoResponse>> GetServiceInfo(CancellationToken cancellationToken = default);
    Task<MTrResponse<MTrGetBranchesResponse>> GetBranches(DateTimeOffset? from, DateTimeOffset? to, MTrBasicSortingField? sortField, MTrSortingOrder? sortOrder, CancellationToken cancellationToken = default);
    Task<MTrResponse<MTrGetOffersResponse>> GetOffers(DateTimeOffset? from, DateTimeOffset? to, MTrBasicSortingField? sortField, MTrSortingOrder? sortOrder, CancellationToken cancellationToken = default);
    Task<MTrResponse<MTrGetRolesResponse>> GetRoles(DateTimeOffset? from, DateTimeOffset? to, MTrBasicSortingField? sortField, MTrSortingOrder? sortOrder, CancellationToken cancellationToken = default);
    Task<MTrResponse<MTrRetrievePlatformLogsV2Response>> RetrievePlatformLogsV2(int? page, int? size, DateTimeOffset? from, DateTimeOffset? to, MTrSortingOrder? sortOrder, MTrRetrievePlatformLogsV2Request request, CancellationToken cancellationToken = default);
}
