using CA_DDD_MS_Template.Domain.Contracts.Services;
using CA_DDD_MS_Template.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CA_DDD_MS_Template.Domain
{
    /// <summary>
    /// Provides methods for configuring and using the domain layer specific services.
    /// </summary>
    public static class DomainBootstrapper
    {
        /// <summary>
        /// Configures the specific domain layer required services for this web application.
        /// </summary>
        /// <param name="aServiceList"></param>
        public static void RegisterDomainServices(this IServiceCollection aServiceList)
        {
            aServiceList.AddScoped<IMembersDomainService, MembersDomainService>();
        }
    }
}
