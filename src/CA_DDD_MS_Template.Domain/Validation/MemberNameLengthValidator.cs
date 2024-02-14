using CA_DDD_MS_Template.Domain.Entities;
using CA_DDD_MS_Template.Domain.Errors;
using FluentValidation;

namespace CA_DDD_MS_Template.Domain.Validation
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
