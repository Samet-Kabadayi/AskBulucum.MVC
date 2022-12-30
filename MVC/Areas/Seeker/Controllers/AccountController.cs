using Entities.DTOs.Seeker;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Areas.Seeker.Controllers
{
    [Area("Seeker")]
    public class AccountController : Controller
    {
        public IActionResult AccountSetting()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AccountSetting(SeekerAccountDto seekerAccountDto)
        {
            return View();
        }


    }
}
