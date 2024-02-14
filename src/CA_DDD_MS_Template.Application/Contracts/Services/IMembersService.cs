using CA_DDD_MS_Template.Application.DTOs;
using TGF.Common.ROP.HttpResult;

namespace CA_DDD_MS_Template.Application.Contracts.Services
{
    public interface IMembersService
    {
        public Task<IHttpResult<PaginatedMemberListDTO>> GetMemberList(
            int aPage, int aPageSize,
            string aSortBy,
            CancellationToken aCancellationToken = default);
    }
}
