using Microsoft.AspNetCore.Mvc;

namespace OrbisEvents.Controllers
{
    public class AccountsController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}