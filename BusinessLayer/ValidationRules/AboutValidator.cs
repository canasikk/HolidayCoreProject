using EntitiyLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator <About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama boş olamaz");
            RuleFor(x=>x.Image1).NotEmpty().WithMessage("görsel seç");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("50den fazla karakterli açıklama gir");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("1500den fazla karakter girme");
        }
    }
}
