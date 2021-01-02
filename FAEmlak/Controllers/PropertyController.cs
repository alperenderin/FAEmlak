using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FAEmlak.Business.Abstract;
using FAEmlak.Data;
using FAEmlak.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FAEmlak.Controllers
{
    public class PropertyController : Controller
    {
        private readonly IPropertyService _propertyService;
        private readonly IFavoriteItemService _favoriteItemService;
        private readonly UserManager<User> _userManager;
        private readonly ICityService _cityService;
        private readonly IStateService _stateService;
        private IWebHostEnvironment _environment;
        private IPhotoService _photoService;

        public PropertyController(IPropertyService propertyService,
            IFavoriteItemService favoriteItemService,
            UserManager<User> userManager,
            ICityService cityService,
            IStateService stateService,
            IPhotoService photoService,
            IWebHostEnvironment environment)
        {
            _propertyService = propertyService;
            _favoriteItemService = favoriteItemService;
            _userManager = userManager;
            _cityService = cityService;
            _stateService = stateService;
            _photoService = photoService;
            _environment = environment;
        }

        [Route("[controller]/{id}/[action]")]
        public async Task<IActionResult> Detail(int id)
        {
            var _property = await _propertyService.GetPropertyByIdAsync(id);
            if (_property != null)
            {
                var isFavorite = false;
                if (User.Identity.IsAuthenticated)
                {
                    isFavorite = _favoriteItemService.IsFavorite(_userManager.GetUserId(User), _property.PropertyId);
                }

                return View(new PropertyDetailViewModel
                {
                    Title = _property.Title,
                    Price = _property.Price,
                    Area = _property.Area,
                    BathroomCount = _property.BathroomCount,
                    BuildingAge = _property.BuildingAge,
                    Description = _property.Description,
                    FloorCount = _property.FloorCount,
                    HasBalcony = _property.HasBalcony,
                    ProductId = _property.PropertyId,
                    PropertyCategory = _property.PropertyCategory,
                    PropertyType = _property.PropertyType,
                    HasStuff = _property.HasStuff,
                    RoomCount = _property.RoomCount,
                    StateId = _property.StateId,
                    WhichFloor = _property.WhichFloor,
                    IsInSite = _property.IsInSite,
                    State = _property.State,
                    Photos = _property.Photos,
                    user = _property.User,
                    IsFavorite = isFavorite,
                });
            }
            return NotFound();
        }

        [Authorize]
        public async Task<IActionResult> Create()
        {
            ViewBag.Cities = new SelectList(await _cityService.GetCitiesAsync(), "CityId", "Name");
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(PropertyDetailViewModel model, List<IFormFile> files)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(User.Identity.Name);

                var property = new Property {
                    UserId = user.Id,
                    Title = model.Title,
                    Description = model.Description,
                    Area = model.Area,
                    BathroomCount = model.BathroomCount,
                    BuildingAge = model.BuildingAge,
                    FloorCount = model.FloorCount,
                    HasBalcony = model.HasBalcony,
                    HasStuff = model.HasStuff,
                    IsInSite = model.IsInSite,
                    Price = model.Price,
                    RoomCount = model.RoomCount,
                    WhichFloor = model.WhichFloor,
                    StateId = model.StateId,
                    PropertyCategory = model.PropertyCategory,
                    PropertyType = model.PropertyType
                };
                _propertyService.Create(property);

                //Fotoğraf işlemleri
                if (files.Count > 0)
                {
                    foreach (var file in files.ToList())
                    {
                        if (file.Length > 0)
                        {
                            //Dosya ismini alıyoruz
                            var fileName = Path.GetFileName(file.FileName);
                            //Benzersiz isim tanımlıyoruz (Guid)
                            var uniqueFileName = Convert.ToString(Guid.NewGuid());
                            //Dosya uzantısını alıyouz
                            var fileExtension = Path.GetExtension(fileName);

                            var newFileName = String.Concat(uniqueFileName, fileExtension);

                            string wwwPath = _environment.WebRootPath;

                            string folderPath = Path.Combine(wwwPath, $"img/{property.PropertyId}");

                            if (!Directory.Exists(folderPath))
                            {
                                Directory.CreateDirectory(folderPath);
                            }

                            string filePath = Path.Combine(folderPath, newFileName);

                            using (FileStream fs = System.IO.File.Create(filePath))
                            {
                                file.CopyTo(fs);
                                fs.Flush();
                            }

                            _photoService.Create(new Photo
                            {
                                PhotoPath = newFileName,
                                PropertyId = property.PropertyId
                            });
                        }
                    }
                }
                return RedirectToRoute(new { controller = "Account", action = "UsersProperties", UserId = user.Id });
            }
            return BadRequest();
        }

        public JsonResult LoadState(int CityId)
        {
            var states = _stateService.GetStates().Where(i => i.CityId == CityId).ToList();
            return Json(new SelectList(states, "Id", "Name"));
        }
    }

}
