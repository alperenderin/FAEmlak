using FAEmlak.Business.Abstract;
using FAEmlak.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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

        public AdminController(RoleManager<IdentityRole> roleManager,
            IPropertyService propertyService,
            UserManager<User> userManager)
        {
            _roleManager = roleManager;
            _propertyService = propertyService;
            _userManager = userManager;
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
        public IActionResult PropertiesList()
        {
            var properties = _propertyService.GetProperties();
            return View(properties);
        }

        [Route("[controller]/Users")]
        public IActionResult UserList()
        {
            var users = _userManager.Users.ToList() ;
            return View(users);
        }

    }
}
