using Entities.DTOs.Seeker;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Services.Abstract;
using Services.ExtraMetots.Abstract;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Entities.Concrete;
using System.Text;
using Entities.DTOs;
using Core.Results.ComplexTypes;

namespace MVC.Areas.Seeker.Controllers
{
    [Area("Seeker")]
    [AllowAnonymous]
    public class AuthController : Controller
    {
        private readonly ISeekerAuthService _seekerAuthService;
        private readonly IExtraMetot _extraMetot;

        public AuthController(ISeekerAuthService authService, IExtraMetot extraMetot)
        {
            _seekerAuthService = authService;
            _extraMetot = extraMetot;
        }
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login(SeekerLoginDto seekerLoginDto)
        {
            var hashedpassword = _extraMetot.DoMD5HashedString(seekerLoginDto.Password);
            var result = _seekerAuthService.CheckLoginUser(seekerLoginDto.Email, hashedpassword);
            if (result.Result.ResultStatus == ResultStatus.Success)
            {
                List<Claim> claims = new List<Claim>();
                //claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()));
                claims.Add(new Claim("Name", result.Result.Data.FirstName ?? string.Empty));
                claims.Add(new Claim("TC", result.Result.Data.Tc));
                claims.Add(new Claim("LastName", result.Result.Data.LastName));         
              

                ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                ClaimsPrincipal principal = new ClaimsPrincipal(identity);

                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                return RedirectToAction("SeekerHome", "Home" , new { Area = "Seeker" });
            }
            else
                return View(seekerLoginDto);
           
        }
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Register(SeekerRegisterDto seekerRegisterDto, RegisterPasswordDto registerPasswordDto)
        {
            if(ModelState.IsValid)
            {
                if (registerPasswordDto.RePassword != registerPasswordDto.Password)
                {
                    return View();
                }
                var result = _seekerAuthService.RegisterForSeeker(seekerRegisterDto, registerPasswordDto.Password);
                if (result.Result.ResultStatus == ResultStatus.Success)
                {
                    return RedirectToAction("Login", "Auth");

                }
              
            }
            return View();
        }
    
        //public IActionResult Logout()
        //{
        //    HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        //    return RedirectToAction(nameof(Login));
        //}
    }
}
