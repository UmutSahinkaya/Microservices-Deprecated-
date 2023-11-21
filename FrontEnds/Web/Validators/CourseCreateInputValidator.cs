using FluentValidation;
using Web.Models.Catalog;

namespace Web.Validators
{
    public class CourseCreateInputValidator:AbstractValidator<CourseCreateInput>
    {
        public CourseCreateInputValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("isim alanı boş bırakılamaz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("açıklama alanı boş bırakılamaz");
            RuleFor(x => x.Feature.Duration).NotEmpty().InclusiveBetween(1, int.MaxValue).WithMessage("süre alanı boş bırakılamaz");
            RuleFor(x => x.Price).NotEmpty().WithMessage("fiyat alanı boş bırakılamaz").ScalePrecision(2, 6).WithMessage("hatalı para formatı");
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("kategory alanı seçiniz.");
        }
    }
}
