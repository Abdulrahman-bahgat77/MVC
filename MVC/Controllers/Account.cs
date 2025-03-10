using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class Account : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

    }
}
