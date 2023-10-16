using Microsoft.AspNetCore.Mvc;

namespace Callis.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
