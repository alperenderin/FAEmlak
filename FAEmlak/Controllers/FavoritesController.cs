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

        public FavoritesController(IFavoriteItemService favoriteItemService, UserManager<User> userManager)
        {
            _favoriteItemService = favoriteItemService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var userId = _userManager.GetUserId(User);
            var favoriteItems = _favoriteItemService.GetFavoriteItems(userId);
            return View(new ListFavoriteItemsModel {
                favoriteItems = favoriteItems
            });
        }
    }
}
