using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OrbisEvents.Data.Models;

namespace OrbisEvents.Controllers
{
    public class AccountsController : Controller
    {
        private SignInManager<User> _signManager;
        private UserManager<User> _userManager;
        public AccountsController(UserManager<User> userManager, SignInManager<User> signManager)
        {
            _userManager = userManager;
            _signManager = signManager;
        }

        [HttpGet]
        public ViewResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(User userModel)
        {
            if (ModelState.IsValid)
            {
                var user = new User { Email = userModel.Email };
                var result = await _userManager.CreateAsync(user);

                if (result.Succeeded)
                {
                    await _signManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View();
        }

        public class LoginViewModel
        {
            public string Email { get; set; }

            public string ReturnUrl { get; set; }
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult Login(string returnUrl = "")
        {
            var model = new LoginViewModel { ReturnUrl = returnUrl };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new User { Email = model.Email };

                await _signManager.SignInAsync(user, false);

                    {
                        return RedirectToAction("Index", "Home");
                    }
                
            }
            ModelState.AddModelError("", "Invalid login attempt");
            return View(model);
        }
    }
}