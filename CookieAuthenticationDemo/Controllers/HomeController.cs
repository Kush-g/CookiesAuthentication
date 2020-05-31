using CookieAuthenticationDemo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CookieAuthenticationDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult Users()
        {
            var uses = new Users();
            return View(uses.GetUsers());
        }

         [Authorize(Policy = "UserPolicy")]
        public ActionResult UsersPolicy()
        {
            var uses = new Users();
            return View("Users", uses.GetUsers());
        }

        [Authorize(Roles = "User")]
        public ActionResult UsersRole()
        {
            var uses = new Users();
            return View("Users", uses.GetUsers());
        }
       
        [Authorize(Roles = "Admin")]
        public ActionResult AdminUser()
        {
            var uses = new Users();
            return View("Users", uses.GetUsers());
        }
    }
}
