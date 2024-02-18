using Microsoft.EntityFrameworkCore;
using Template_CA_DDD_MS.Domain.Entities;

namespace Template_CA_DDD_MS.Infrastructure.DataAccess.DbContexts
{
    public class MembersDbContext(DbContextOptions<MembersDbContext> aOptions) : DbContext(aOptions)
    {
        public virtual DbSet<Member> Members { get; set; }
    }
}
