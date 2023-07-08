using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı Boş Bırakmayınız");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alanı Boş Bırakmayınız");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı alanı Boş Bırakmayınız");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı Boş Bırakmayınız");
            RuleFor(x => x.Password).NotEmpty().WithMessage("şifre  alanı Boş Bırakmayınız");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("şifre tekrar  alanı Boş Bırakmayınız");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("lütfen en fazla 30  karakter girşi yapınız ");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("lütfen en fazla 2 karakter veri girişi yapınız");
            RuleFor(x => x.ConfirmPassword).Equal(y=>y.Password).WithMessage("Parolalarınız eşleşmiyor");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen geçerli mail adresi giriniz");
        }
    }
}
