using Template_CA_DDD_MS.Application.DTOs;
using TGF.Common.ROP.HttpResult;

namespace Template_CA_DDD_MS.Application.Contracts.Services
{
    public interface IMembersService
    {
        public Task<IHttpResult<PaginatedMemberListDTO>> GetMemberList(
            int aPage, int aPageSize,
            string aSortBy,
            CancellationToken aCancellationToken = default);
    }
}
