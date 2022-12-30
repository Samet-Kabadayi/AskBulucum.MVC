using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public  class RegisterPasswordDto : IDto
    {
        [Required(ErrorMessage ="Şifre alanı zorunludur")]
        public string Password { get; set; }

        [Compare("Password",ErrorMessage ="Şifreler uyuşmuyor")]
        [Required(ErrorMessage = "Şifre alanı zorunludur")]
        public string RePassword { get; set; }
    }
}
