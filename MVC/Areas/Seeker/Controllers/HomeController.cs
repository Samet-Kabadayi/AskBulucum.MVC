using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Abstract;
using Services.ExtraMetots.Class;

namespace MVC.Areas.Seeker.Controllers
{
    [Area("Seeker")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IFinderService _finderService;
        private readonly ITcKimlikService _tcKimlikService;
        private readonly ISeekerService _seekerService;

        public HomeController(IFinderService finderService, ITcKimlikService tcKimlikService, ISeekerService seekerService)
        {
            _finderService = finderService;
            _tcKimlikService = tcKimlikService;
            _seekerService = seekerService;
        }
        public async Task<IActionResult> SeekerHome()
        {     
            var result = _finderService.GetAllFindersNoneDeleted();
            if (ModelState.IsValid)
            {
                return View(result);
            }
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult VerifyTc()
        {
            return View();
        }

        [HttpPost]
        public IActionResult VerifyTc(CheckPerson checkPrson)
        {
            //string name = User.FindFirst("Name").Value;
            //string lname = User.FindFirst("LastName").Value;          
            //long Tc = Convert.ToInt64((User.FindFirst("TC").Value));
            //int date = checkPrson.BirthDate;
            string name = "cüneyt";
            string lname = "çavdar";
            long Tc = 18556740196;
            int date = 1985;
            var result = _tcKimlikService.IsPErson(name, lname, Tc, date);
            if (result.Result)
            {
                //var deneme = _seekerService.ChangeConfirmPerson(User.FindFirst("TC").Value);
                //if (!deneme)
                //{
                //    ModelState.AddModelError("", "işlem başarısız");
                //    View(checkPrson);
                //}
              return View();
            }
            return View();
            
        }

        public IActionResult VerifyStatus()
        {
            return View();
        }

    }
}
