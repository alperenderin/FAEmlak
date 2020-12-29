using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FAEmlak.Controllers
{
    public class AdminController : Controller
    {
        private RoleManager<IdentityRole> _roleManager;
        public AdminController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
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

    }
}
