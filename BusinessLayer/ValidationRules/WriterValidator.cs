using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş bırakamazsınız.");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar soyadını boş bırakamazsınız.");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında kısmını boş bırakamazsınız.");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Unvan kısmını boş bırakamazsınız.");
            RuleFor(x => x.WriterSurname).MaximumLength(2).WithMessage("Lütfen en fazla 20 karakter girişi yapınız.");
            RuleFor(x => x.WriterSurname).MaximumLength(5).WithMessage("Lütfen en fazla 20 karakter girişi yapınız.");
        }
    }
}
