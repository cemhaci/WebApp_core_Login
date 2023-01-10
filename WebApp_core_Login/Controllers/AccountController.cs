using Microsoft.AspNetCore.Mvc;
using WebApp_core_Login.Models.viewModel;

namespace WebApp_core_Login.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {

            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(registerViewModel model)
        {

            return View();
        }
    }
}
