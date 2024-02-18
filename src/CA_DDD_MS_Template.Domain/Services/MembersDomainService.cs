using Template_CA_DDD_MS.Domain.Contracts.Services;
using Template_CA_DDD_MS.Domain.Entities;
using Template_CA_DDD_MS.Domain.Errors;
using TGF.Common.ROP;
using TGF.Common.ROP.HttpResult;
using TGF.Common.ROP.Result;

namespace Template_CA_DDD_MS.Domain.Services
{
    /// <summary>
    /// Domain service with complex business logic, in this case related with the Member entitiy.
    /// </summary>
    internal class MembersDomainService : IMembersDomainService
    {
        public IHttpResult<Unit> IsNameValid(Member aMember)
        => aMember.Name != "InvalidName"
            ? Result.SuccessHttp(Unit.Value)
            : Result.Failure<Unit>(DomainErrors.Member.InvalidName);
    }
}
