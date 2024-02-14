using Microsoft.EntityFrameworkCore;
using CA_DDD_MS_Template.Domain.Entities;

namespace CA_DDD_MS_Template.Infrastructure.DataAccess.DbContexts
{
    public class MembersDbContext(DbContextOptions<MembersDbContext> aOptions) : DbContext(aOptions)
    {
        public virtual DbSet<Member> Members { get; set; }
    }
}
