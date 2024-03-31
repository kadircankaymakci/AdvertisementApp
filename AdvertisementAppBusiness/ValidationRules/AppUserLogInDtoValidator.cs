using AdvertisementApp.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementAppBusiness.ValidationRules
{
    public class AppUserLogInDtoValidator: AbstractValidator<AppUserLogInDto>
    {
        public AppUserLogInDtoValidator()
        {
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı adı alanı boş olamaz");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş olamaz.");
        }
    }
}
