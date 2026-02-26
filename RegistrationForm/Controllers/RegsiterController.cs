using Microsoft.AspNetCore.Mvc;
using registration.Models;

namespace registration.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Register User)
        {
            if (ModelState.IsValid)
            {
                return Content(
                    $"Registration Successful\nname: {User.Name}\nEmail):{ User.Email}\nAge: { User.Age}\n");


            }
            return View(User);
        }
    }

