using Template_CA_DDD_MS.Application.Contracts.Repositories;
using Template_CA_DDD_MS.Application.Contracts.Services;
using Template_CA_DDD_MS.Application.DTOs;
using Template_CA_DDD_MS.Application.Mappings;
using Template_CA_DDD_MS.Domain.Entities;
using TGF.Common.ROP.HttpResult;

namespace Template_CA_DDD_MS.Application.Services
{
    public class MembersService : IMembersService
    {
        private readonly IMemberRepository _memberRepository;
        public MembersService(
            IMemberRepository aMemberRepository)
        {
            _memberRepository = aMemberRepository;
        }

        #region IMemberService
        public async Task<IHttpResult<PaginatedMemberListDTO>> GetMemberList(
            int aPage, int aPageSize,
            string aSortBy,
            CancellationToken aCancellationToken = default)
        => await _memberRepository.GetMembersListAsync(aPage, aPageSize, aSortBy, aCancellationToken)
            .Bind(memberList => GetPaginatedMemberListDTO(memberList, aPage, aPageSize));


        #endregion

        #region Private 
        private async Task<IHttpResult<PaginatedMemberListDTO>> GetPaginatedMemberListDTO(IEnumerable<Member> aMemberList, int aCurrentPage, int aPageSize)
        => await _memberRepository.GetCountAsync()
            .Map(memberCount => new PaginatedMemberListDTO(aCurrentPage, (int)Math.Ceiling((double)memberCount / aPageSize), aPageSize, memberCount, aMemberList.Select(member => member.ToDto()).ToArray()));
        #endregion
    }
}
