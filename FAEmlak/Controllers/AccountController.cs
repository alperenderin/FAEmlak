using System;
using System.Threading.Tasks;
using FAEmlak.Business.Abstract;
using FAEmlak.Data;
using FAEmlak.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FAEmlak.Controllers
{
    public class AccountController: Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;
        private IPropertyService _propertyService;
        private RoleManager<IdentityRole> _roleManager;

        public AccountController(
            RoleManager<IdentityRole> roleManager,
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            IPropertyService propertyService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _propertyService = propertyService;
            _roleManager = roleManager;
        }

        public IActionResult Login(string ReturnUrl = null)
        {
            return View(new LoginModel()
            {
                ReturnUrl = ReturnUrl
            });
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                ModelState.AddModelError("", "No account created by mail");
            }
            else
            {
                var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);
                if (result.Succeeded)
                {
                    return Redirect(model.ReturnUrl ?? "~/");
                }
                ModelState.AddModelError("", "Username or password is incorrect");
            }
           
            return View(model);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = new User()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                UserName = model.Email
            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                var role = await _roleManager.FindByNameAsync("User");
                await _userManager.AddToRoleAsync(user, role.Name);
                return RedirectToAction("Login", "Account");
            }
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Redirect("~/");
        }

        [Route("[controller]/{UserId}/Properties")]
        public async Task<IActionResult> UsersProperties(string UserId)
        {
            var user = await _userManager.FindByIdAsync(UserId);

            if (user != null)
            {
                ViewBag.UserName = user.Email;
                var properties = await _propertyService.GetPropertiesByUserId(UserId);
                return View(properties);
            }
            return NotFound();
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
