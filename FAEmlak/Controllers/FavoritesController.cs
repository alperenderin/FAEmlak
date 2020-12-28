using FAEmlak.Business.Abstract;
using FAEmlak.Identity;
using FAEmlak.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FAEmlak.Controllers
{
    public class FavoritesController : Controller
    {
        private readonly IFavoriteItemService _favoriteItemService;
        private readonly UserManager<User> _userManager;
        private readonly IPropertyService _propertyService;

        public FavoritesController(IFavoriteItemService favoriteItemService, UserManager<User> userManager, IPropertyService propertyService)
        {
            _favoriteItemService = favoriteItemService;
            _userManager = userManager;
            _propertyService = propertyService;
        }

        public IActionResult Index()
        {
            var userId = _userManager.GetUserId(User);
            var favoriteItems = _favoriteItemService.GetFavoriteItems(userId);
            return View(new ListFavoriteItemsModel {
                favoriteItems = favoriteItems
            });
        }

        [HttpPost]
        public IActionResult AddFavorite(int PropertyId)
        {
            if (User.Identity.IsAuthenticated)
            {
                var userId = _userManager.GetUserId(User);
                if (userId != null)
                {
                    var property = _propertyService.GetById(PropertyId);
                    if (property != null)
                    {
                        if (!_favoriteItemService.IsFavorite(userId, PropertyId))
                        {
                            _favoriteItemService.Create(new Entity.FavoriteItem
                            {
                                UserId = userId,
                                PropertyId = PropertyId,
                            });
                            return Ok();
                        }
                    }
                }
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult RemoveFavorite(int PropertyId)
        {
            if (User.Identity.IsAuthenticated)
            {
                var userId = _userManager.GetUserId(User);
                if (userId != null)
                {
                    var property = _propertyService.GetById(PropertyId);
                    if (property != null)
                    {
                        if (_favoriteItemService.IsFavorite(userId, PropertyId))
                        {
                            var favoriteItem = _favoriteItemService.GetByUserIdAndPropertyId(userId, PropertyId);
                            _favoriteItemService.Delete(favoriteItem);
                            return Ok();
                        }
                    }
                }
            }
            return NotFound();
        }

    }
}
