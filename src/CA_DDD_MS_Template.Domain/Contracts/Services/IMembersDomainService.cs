using Template_CA_DDD_MS.Domain.Entities;
using TGF.Common.ROP.HttpResult;
using TGF.Common.ROP;

namespace Template_CA_DDD_MS.Domain.Contracts.Services
{
    /// <summary>
    /// Interface for a domain service with complex business logic, in this case related with the Member entitiy.
    /// </summary>
    internal interface IMembersDomainService
    {
        public IHttpResult<Unit> IsNameValid(Member aMember);
    }
}
