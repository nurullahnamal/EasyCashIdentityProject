using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidation:AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alanı boş geçilemez");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Username alanı boş geçilemez");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("şifre alanı boş geçilemez");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage(" Şifre onayalanı boş geçilemez");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen En fazla 30 karakter giriş yapının");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Lütfen En az 2 karakter giriş yapının");
            RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("Parolalar Eşleşmiyor");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen Geçerli bir Mail Adresi Giriniz");
        }
    }
}
