using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApp_core_Login.Controllers
{
    public class adminController1 : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
