using Microsoft.AspNetCore.Mvc;
using SanaProject1.Models;

namespace SanaProject1.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index(User user)
        {
            return View(user);
        }
    }
}
