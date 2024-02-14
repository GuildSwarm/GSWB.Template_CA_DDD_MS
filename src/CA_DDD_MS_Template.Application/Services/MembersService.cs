using CA_DDD_MS_Template.Application.Contracts.Repositories;
using CA_DDD_MS_Template.Application.Contracts.Services;
using CA_DDD_MS_Template.Application.DTOs;
using CA_DDD_MS_Template.Application.Mappings;
using CA_DDD_MS_Template.Domain.Entities;
using TGF.Common.ROP.HttpResult;

namespace CA_DDD_MS_Template.Application.Services
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
