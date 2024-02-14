using Microsoft.Extensions.DependencyInjection;

namespace CA_DDD_MS_Template.Application
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
