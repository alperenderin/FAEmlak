using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FAEmlak.Business.Abstract;
using FAEmlak.Data;
using FAEmlak.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FAEmlak.Controllers
{
    public class PropertyController : Controller
    {
        private readonly IPropertyService _propertyService;
        private readonly IFavoriteItemService _favoriteItemService;
        private readonly UserManager<User> _userManager;

        public PropertyController(IPropertyService propertyService, IFavoriteItemService favoriteItemService, UserManager<User> userManager)
        {
            _propertyService = propertyService;
            _favoriteItemService = favoriteItemService;
            _userManager = userManager;
        }

        [Route("[controller]/{id}/[action]")]
        public async Task<IActionResult> Detail(int id)
        {
            Property _property = await _propertyService.GetPropertyByIdAsync(id);
            var isFavorite = false;
            if (User.Identity.IsAuthenticated)
            {
                isFavorite = _favoriteItemService.IsFavorite(_userManager.GetUserId(User), _property.PropertyId);
            }

            return View(new PropertyDetailViewModel
            {
                ProductId = _property.PropertyId,
                Title = _property.Title,
                user = _property.User,
                Price = _property.Price,
                BathroomCount = _property.BathroomCount,
                BuildingAge = _property.BuildingAge,
                Area = _property.Area,
                FloorCount = _property.FloorCount,
                State = _property.State,
                Created = _property.Created,
                Description = _property.Description,
                IsFavorite = isFavorite
            }) ;
        }
    }
}
