using FAEmlak.Business.Abstract;
using FAEmlak.Data;
using FAEmlak.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FAEmlak.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private RoleManager<IdentityRole> _roleManager;
        private IPropertyService _propertyService;
        private UserManager<User> _userManager;
        private ICityService _cityService;
        private IStateService _stateService;
        private IPhotoService _photoService;
        private readonly IHtmlLocalizer<AdminController> _localizer;

        public AdminController(RoleManager<IdentityRole> roleManager,
            IPropertyService propertyService,
            UserManager<User> userManager,
            ICityService cityService,
            IStateService stateService,
            IPhotoService photoService,
            IHtmlLocalizer<AdminController> localizer)
        {
            _roleManager = roleManager;
            _propertyService = propertyService;
            _userManager = userManager;
            _cityService = cityService;
            _stateService = stateService;
            _photoService = photoService;
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("[controller]/Roles")]
        public IActionResult RolesList()
        {
            var roles = _roleManager.Roles.ToList();
            return View(roles);
        }

        [Route("[controller]/Properties")]
        public async Task<IActionResult> PropertiesList()
        {
            var properties = await _propertyService.GetPropertiesAsync();
            return View(properties);
        }

        [Route("[controller]/Users")]
        public IActionResult UserList()
        {
            var users = _userManager.Users.ToList() ;
            return View(users);
        }

        [Route("[controller]/Users/Create")]
        public IActionResult CreateUser()
        {
            var roles = _roleManager.Roles.ToList();
            return View(roles);
        }

        [Route("[controller]/Users/Create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateUser(AdminUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Password == model.ConfirmPassword)
                {
                    var user = new User
                    {
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        UserName = model.Email,
                        Email = model.Email,
                    };

                    var result = await _userManager.CreateAsync(user, model.Password);
                    if (result.Succeeded)
                    {
                        var role = await _roleManager.FindByIdAsync(model.RoleId);
                        await _userManager.AddToRoleAsync(user, role.Name);
                        return RedirectToAction("UserList");
                    }
                }
            }
            return View(model);
        }

        [Route("[controller]/Users/{UserName}")]
        [HttpGet]
        public async Task<IActionResult> EditUser(string UserName)
        {
            var user = await _userManager.FindByNameAsync(UserName);
            if (user != null)
            {
                var roles =  _roleManager.Roles.ToList();
                var userRole = await _userManager.GetRolesAsync(user);
                return View(new AdminUserViewModel
                {
                    UserId = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    RoleId = userRole.ToList().ToString(),
                    Roles = roles
                }); ;
            }
            return NotFound();
        }

        [Route("[controller]/Users/{UserName}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditUser(AdminUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(model.UserId);
                if (user != null)
                {
                    user.FirstName = model.FirstName;
                    user.LastName = model.LastName;
                    user.UserName = model.Email;
                    user.Email = model.Email;

                    var result = await _userManager.UpdateAsync(user);

                    if (result.Succeeded)
                    {
                        var userRole = await _userManager.GetRolesAsync(user);
                        var newRole = await _roleManager.FindByIdAsync(model.RoleId);
                        await _userManager.RemoveFromRoleAsync(user, userRole.ToList()[0]);
                        await _userManager.AddToRoleAsync(user, newRole.Name);

                        return RedirectToAction("UserList");
                    }
                }
                return NotFound();
            }
            return View(model);
        }

        public async Task<IActionResult> DeleteUser(string UserId)
        {
            var user = await _userManager.FindByIdAsync(UserId);
            await _userManager.DeleteAsync(user);
            return RedirectToAction("UserList");
        }

        [HttpGet]
        [Route("[controller]/Cities")]
        public async Task<IActionResult> CityList()
        {
            var cities = await _cityService.GetCitiesAsync();
            return View(cities);
        }

        [Route("[controller]/Cities/Create")]
        public IActionResult CreateCity()
        {
            return View();
        }

        [HttpPost]
        [Route("[controller]/Cities/Create")]
        public IActionResult CreateCity(string CityName)
        {
            _cityService.Create(new City {
                Name = CityName
            });;
            return RedirectToAction("CityList");

        }

        [Route("[controller]/Cities/{CityId}")]
        [HttpGet]
        public IActionResult EditCity(int CityId)
        {
            var city =  _cityService.GetById(CityId);
            if (city != null)
            {
                return View(city); ;
            }
            return NotFound();
        }

        [HttpPost]
        [Route("[controller]/Cities/{id}")]
        [ValidateAntiForgeryToken]
        public IActionResult EditCity(City city)
        {
            if (ModelState.IsValid)
            {
                _cityService.Update(city);

                return RedirectToAction("CityList");
            }

            return NotFound();
        }

        public async Task<IActionResult> DeleteCity(int CityId)
        {
            var city = await _cityService.GetCityWithStatesByIdAsync(CityId);
            if (city != null)
            {
                if (city.States.Count > 0)
                {
                    //Şehirlere bağlı ilçeler de silinecek
                    foreach (var state in city.States)
                    {
                        _stateService.Delete(state);
                    }
                }
                _cityService.Delete(city);
            }
            return RedirectToAction("CityList");
        }


        [HttpGet]
        [Route("[controller]/States")]
        public IActionResult StateList()
        {
            var states = _stateService.GetStates();
            return View(states);
        }

        [Route("[controller]/States/Create")]
        public async Task<IActionResult> CreateState()
        {
            var cities = await _cityService.GetCitiesAsync();
            return View(cities);
        }

        [HttpPost]
        [Route("[controller]/States/Create")]
        public IActionResult CreateState(string Name,int CityId)
        {
            _stateService.Create(new State
            {
                Name = Name,
                CityId = CityId
            }); ;
            return RedirectToAction("StateList");

        }

        public IActionResult DeleteState(int StateId)
        {
            var state = _stateService.GetById(StateId);
            if (state != null)
            {
                _stateService.Delete(state);
            }
            return RedirectToAction("StateList");
        }

        [Route("[controller]/States/{StateId}")]
        [HttpGet]
        public async Task<IActionResult> EditState(int StateId)
        {
            var state = _stateService.GetById(StateId);
            var cities = await _cityService.GetCitiesAsync();
            if (state != null)
            {
                return View(new AdminStateViewModel {
                    state = state,
                    cities = cities
                });
            }
            return NotFound();
        }

        [HttpPost]
        [Route("[controller]/States/{id}")]
        [ValidateAntiForgeryToken]
        public IActionResult EditState(State state)
        {
            if (ModelState.IsValid)
            {
                _stateService.Update(state);

                return RedirectToAction("States");
            }

            return NotFound();
        }


        [Route("[controller]/Properties/Add")]
        public async Task<IActionResult> CreateProperty()
        {
            ViewBag.Cities = new SelectList(await _cityService.GetCitiesAsync(), "CityId", "Name");
            return View();
        }


        public async Task<IActionResult> DeleteProperty(int PropertyId)
        {
            var property = await _propertyService.GetPropertyByIdAsync(PropertyId);
            if (property != null)
            {
                if (property.Photos.Count > 0)
                {
                    for (int i = 0; i < property.Photos.Count; i++)
                    {
                        _photoService.Delete(property.Photos[i]);
                    }
                }
                _propertyService.Delete(property);
            }
            return RedirectToAction("PropertiesList");
        }

        public JsonResult LoadState(int CityId)
        {
            var states = _stateService.GetStates().Where(i => i.CityId == CityId).ToList();
            return Json(new SelectList(states, "Id", "Name"));
        }
       
    }
}
