using FluentValidation;
using Web.Models.Discounts;

namespace Web.Validators
{
    public class DiscountApplyInputValidator:AbstractValidator<DiscountApplyInput>
    {
        public DiscountApplyInputValidator()
        {
            RuleFor(x => x.Code).NotEmpty().WithMessage("varsa indirim kuponunu giriniz");
        }
    }
}
