using Microsoft.AspNetCore.Mvc;

namespace EmptyWeb.Controllers
{
    public class HomeController :Controller
    {
        public HomeController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Hakkimizda()
        {
            return View();
        }

        public IActionResult Iletisim()
        {
            return View();
        }
    }
}
