using Template_CA_DDD_MS.Application.DTOs;
using Template_CA_DDD_MS.Domain.Entities;
using Common.Domain.ValueObjects;
using System.Data;


namespace Template_CA_DDD_MS.Application.Mappings
{
    public static class MemberMapping
    {
        public static MemberDTO ToDto(this Member aMember)
        => new ($"{aMember.Name}, aka {aMember.Nickname}",aMember.Type);
    }
}
