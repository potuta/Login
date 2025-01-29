using Microsoft.AspNetCore.Mvc;

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
            if (!ModelState.IsValid)
            {
                return View(login);
            }

            if (login.Username == "admin" && login.Password == "admin")
            {
                Console.WriteLine($"Correct credentials: {login.Username}, {login.Password}");
                return RedirectToAction("Index", "Home");
            }
            else
            {
                Console.WriteLine($"Wrong credentials: {login.Username}, {login.Password}");
                return View(login);
            }
        }
    }
}
