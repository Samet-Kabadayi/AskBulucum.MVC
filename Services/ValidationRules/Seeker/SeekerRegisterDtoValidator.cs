using Entities.DTOs.Seeker;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ValidationRules.Seeker
{
    public class SeekerRegisterDtoValidator : AbstractValidator<SeekerRegisterDto>
    {
        public SeekerRegisterDtoValidator()
        {
            RuleFor(x=>x.Email).NotEmpty().WithMessage("Email alanı zorunludur");
            RuleFor(x=>x.Email).EmailAddress().WithMessage("Geçerli bir Email adresi giriniz");
            RuleFor(x=>x.Phone).NotEmpty().WithMessage("Telefon alanı zorunludur");
            RuleFor(x=>x.FirstName).NotEmpty().WithMessage("Ad alanı zorunludur");
            RuleFor(x=>x.LastName).NotEmpty().WithMessage("SoyAd alanı zorunludur");
            RuleFor(x=>x.TC).NotEmpty().WithMessage("Kimlik alanı zorunludur");
        }
    }
}
