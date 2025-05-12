using MatchTraderBApi.Enums;
using MatchTraderBApi.Enums.SortingFields;
using MatchTraderBApi.Models.Requests.General;
using MatchTraderBApi.Models.Responses;
using MatchTraderBApi.Models.Responses.General;

namespace MatchTraderBApi.Services.Interfaces;

public interface IMTrGeneralBrokerApi
{
    Task<MTrResponse<MTrGetServiceInfoResponse>> GetServiceInfo();
    Task<MTrResponse<MTrGetBranchesResponse>> GetBranches(DateTime? from, DateTime? to, MTrBasicSortingField? sortField, MTrSortingOrder? sortOrder);
    Task<MTrResponse<MTrGetOffersResponse>> GetOffers(DateTime? from, DateTime? to, MTrBasicSortingField? sortField, MTrSortingOrder? sortOrder);
    Task<MTrResponse<MTrGetRolesResponse>> GetRoles(DateTime? from, DateTime? to, MTrBasicSortingField? sortField, MTrSortingOrder? sortOrder);
    Task<MTrResponse<MTrRetrievePlatformLogsV2Response>> RetrievePlatformLogsV2(int? page, int? size, DateTime? from, DateTime? to, MTrSortingOrder? sortOrder, MTrRetrievePlatformLogsV2Request request);
}
