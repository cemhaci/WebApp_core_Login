using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApp_core_Login.Controllers
{
    public class adminController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
