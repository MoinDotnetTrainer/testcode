using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UsersController : Controller
    {

        [HttpGet]  // exe on form load
        public IActionResult AddUsers() {
            return View();
        }

        [HttpPost]  // exe on click
        public IActionResult AddUsers(UsersModel data)
        {

            // ill take this data to db
            return View();
        }
    }
}
