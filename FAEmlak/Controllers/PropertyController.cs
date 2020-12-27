using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FAEmlak.Business.Abstract;
using FAEmlak.Entity;
using FAEmlak.Models;
using Microsoft.AspNetCore.Mvc;

namespace FAEmlak.Controllers
{
    public class PropertyController : Controller
    {
        private readonly IPropertyService _propertyService;
        public PropertyController(IPropertyService propertyService)
        {
            _propertyService = propertyService;
        }

        [Route("[controller]/{id}/[action]")]
        public IActionResult Detail(int id)
        {
            Property _property = _propertyService.GetById(id);

            return View(new PropertyDetailViewModel
            {
                Title = _property.Title,
                Price = _property.Price,
                BathroomCount = _property.BathroomCount,
                BuildingAge = _property.BuildingAge,
                Area = _property.Area,
                FloorCount = _property.FloorCount,
                State = _property.State,
                Created = _property.Created,
                Description = _property.Description
            }) ;
        }
    }
}
