﻿using Template_CA_DDD_MS.Infrastructure.DataAccess.DbContexts;
using TGF.CA.Infrastructure.DB.PostgreSQL;

namespace Template_CA_DDD_MS.Infrastructure.DataAccess
{
    //USE: dotnet ef migrations add InitialCreate in PowerShell to create an initial migration.

    /// <summary>
    /// Provides a factory for creating instances of <see cref="MembersDbContext"/> during design time.
    /// This is used primarily for Entity Framework migrations and other design-time operations.
    /// </summary>
    /// <remarks>
    /// WARNING: This factory should ONLY be used in a development environment for design-time operations.
    /// Production or Staging connection strings will never be used for design-time operations. 
    /// </remarks>
    public class AuthorizationDbContextFactory : PostgreSQLDesignTimeDbContextFactory<MembersDbContext>
    {
    }
}
