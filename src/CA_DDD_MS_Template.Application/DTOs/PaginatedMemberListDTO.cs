

namespace CA_DDD_MS_Template.Application.DTOs
{
    public record PaginatedMemberListDTO(int CurrentPage, int TotalPages, int PageSize, int TotalCount, MemberDTO[] MemberList);
}
