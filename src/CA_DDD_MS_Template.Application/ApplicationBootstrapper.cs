using Microsoft.Extensions.DependencyInjection;

namespace Template_CA_DDD_MS.Application
{
    /// <summary>
    /// Provides methods for configuring and using the application layer specific services.
    /// </summary>
    public static class ApplicationBootstrapper
    {
        /// <summary>
        /// Configures the specific application layer required services for this web application.
        /// </summary>
        /// <param name="aServiceList"></param>
        public static void RegisterApplicationServices(this IServiceCollection aServiceList)
        {
            //aServiceList.AddScoped<IRolesService, RolesService>();
            //aServiceList.AddScoped<IMembersService, MembersService>();
        }
    }
}
