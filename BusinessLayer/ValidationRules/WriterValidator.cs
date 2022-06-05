﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı soyadı kısmı boş geçilemez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("mail adresi  boş geçilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("şifre  boş geçilemez");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("lütfen en az 2 karakter girisi yapın");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("lütfen en fazla 50 karakter girisi yapın");

        }

    }
}
