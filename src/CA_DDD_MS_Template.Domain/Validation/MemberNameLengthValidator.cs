using Template_CA_DDD_MS.Domain.Entities;
using Template_CA_DDD_MS.Domain.Errors;
using FluentValidation;

namespace Template_CA_DDD_MS.Domain.Validation
{
    public class MemberNameLengthValidator : AbstractValidator<Member>
    {
        public MemberNameLengthValidator()
        {
            RuleFor(member => member.Name)
                .Length(0, 32).WithMessage(DomainErrors.Validation.Member.TooLongNameLength);
        }
    }
}
