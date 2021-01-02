using System;
using System.Linq;
using System.Threading.Tasks;
using FAEmlak.Business.Abstract;
using FAEmlak.Data;
using FAEmlak.Data.Entity;
using FAEmlak.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FAEmlak.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IPropertyService _propertyService;
        private readonly ICityService _cityService;
        private readonly IStateService _stateService;

        public CategoryController(IPropertyService propertyService, ICityService cityService, IStateService stateService)
        {
            _propertyService = propertyService;
            _cityService = cityService;
            _stateService = stateService;
        }

        [HttpGet]
        public async Task<IActionResult> ListCategories(string propertyType, string propertyCategory)
        {
            try
            {
                PropertyType type = (PropertyType)Enum.Parse(typeof(PropertyType), propertyType);
                PropertyCategory category = (PropertyCategory)Enum.Parse(typeof(PropertyCategory), propertyCategory);

                var model = new ListCategoriesModel
                {
                    properties = await _propertyService.GetPropertiesByTypeAndCategoryAsync(type, category)
                };
                ViewBag.Cities = new SelectList(await _cityService.GetCitiesAsync(), "CityId", "Name");

                return View(model);
            }
            catch (Exception ex)
            {
                return View();
            }

        }

        [HttpPost]
        public async Task<IActionResult> Search(SearchModel model)
        {
            var results = _propertyService.GetProperties(model).ToList();
            ViewBag.Cities = new SelectList(await _cityService.GetCitiesAsync(), "CityId", "Name");
            return View(results);
        }

        public JsonResult LoadState(int CityId)
        {
            var states = _stateService.GetStates().Where(i => i.CityId == CityId).ToList();
            return Json(new SelectList(states, "Id", "Name"));
        }
    }
}
