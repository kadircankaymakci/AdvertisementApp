using AdvertisementApp.UI.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvertisementApp.UI.ValidationRules
{
    public class UserCreateModelValidator : AbstractValidator<UserCreateModel>
    {
        public UserCreateModelValidator()
        {
            RuleFor(x => x.Firstname).NotEmpty().WithMessage("Ad alanı boş olamaz.");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alanı boş olamaz.");
            RuleFor(x => x.GenderId).NotEmpty().WithMessage("Cinsiyet seçiniz.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Parola alanı boş olamaz.");
            RuleFor(x => x.Password).MinimumLength(3).WithMessage("Parola en az 3 karakter olmalıdır.");
            RuleFor(x => x.Password).Equal(x => x.ConfirmPassword).WithMessage("Parolalar eşleşmiyor");
            RuleFor(x => x.Username).MinimumLength(3).WithMessage("Kullanıcı adı en az 3 karakter olmalıdır.");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı adı boş olamaz");
            RuleFor(x => new
            {
                x.Username,
                x.Firstname
            }).Must(x => CanNotFirstName(x.Username, x.Firstname)).WithMessage("Kullanıcı adı Adınızı içeremez").When(x => x.Firstname != null && x.Username != null);
        }

        private bool CanNotFirstName(string username, string firstname)
        {
            return !username.Contains(firstname);
        }
    }
}
