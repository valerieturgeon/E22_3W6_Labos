using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ZombieParty_Models;

namespace ZombieParty.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;
        //TODO 07: Injection des resources localizer locals / shared
        private readonly IStringLocalizer<HomeController> _localizer;
        private readonly IStringLocalizer<SharedResource> _sharedLocalizer;



        public HomeController(ILogger<HomeController> logger, IStringLocalizer<HomeController> localizer, IStringLocalizer<SharedResource> sharedLocalizer)
    {
      _logger = logger;
      _localizer = localizer;
      _sharedLocalizer = sharedLocalizer;

     }

        public IActionResult Index()
    {
            ViewData["Title"] = this._localizer["HomeIndexTitle"];
            return View();
    }

    public IActionResult Privacy()
    {
            ViewBag.Title = _localizer["PrivacyTitle"]; 
            return View();
    }

    [HttpPost]
    public IActionResult SetLanguage(string culture, string returnUrl)
    {
        var cookie = CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture));
        var name = CookieRequestCultureProvider.DefaultCookieName;

        Response.Cookies.Append(name, cookie, new CookieOptions
        {
            Path = "/",
            Expires = DateTimeOffset.UtcNow.AddYears(1),
        });

        return LocalRedirect(returnUrl);
    }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
