

namespace Template_CA_DDD_MS.Application.DTOs
{
    public record PaginatedMemberListDTO(int CurrentPage, int TotalPages, int PageSize, int TotalCount, MemberDTO[] MemberList);
}
