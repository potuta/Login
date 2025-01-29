using Microsoft.AspNetCore.Mvc;
using LoginModel;

namespace Login.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginModel.Login login)
        {
           if (ModelState.IsValid)
           {
               return RedirectToAction("Index", "Home");
           }
           return View(login);

        //    if (login.Username == "admin" && login.Password == "admin")
        //     {
        //         return RedirectToAction("Index", "Home");
        //     }
        //     else
        //     {
        //         return View();
        //     }
        }
    }
}
