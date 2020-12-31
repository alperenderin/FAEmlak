using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FAEmlak.Models;
using FAEmlak.Business.Abstract;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;

namespace FAEmlak.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPropertyService _propertyService;

        public HomeController(IPropertyService propertyService)
        {
            _propertyService = propertyService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult CultureManagement(string Culture, string returnUrl)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName, CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(Culture)),
                new CookieOptions { Expires = DateTimeOffset.Now.AddDays(30)});
            return LocalRedirect(returnUrl);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
