using CA_DDD_MS_Template.Application.DTOs;
using CA_DDD_MS_Template.Domain.Entities;
using Common.Domain.ValueObjects;
using System.Data;


namespace CA_DDD_MS_Template.Application.Mappings
{
    public static class MemberMapping
    {
        public static MemberDTO ToDto(this Member aMember)
        => new ($"{aMember.Name}, aka {aMember.Nickname}",aMember.Type);
    }
}
