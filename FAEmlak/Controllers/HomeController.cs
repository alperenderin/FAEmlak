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
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FAEmlak.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPropertyService _propertyService;
        private readonly ICityService _cityService;
        private readonly IStateService _stateService;

        public HomeController(IPropertyService propertyService, ICityService cityService, IStateService stateService)
        {
            _propertyService = propertyService;
            _cityService = cityService;
            _stateService = stateService;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Cities = new SelectList(await _cityService.GetCitiesAsync(), "CityId", "Name");
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

        public JsonResult LoadState(int CityId)
        {
            var states = _stateService.GetStates().Where(i => i.CityId == CityId).ToList();
            return Json(new SelectList(states, "Id", "Name"));
        }
    }
}
