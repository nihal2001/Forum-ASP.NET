using Microsoft.AspNetCore.Mvc;

namespace Forum.Controllers {

    public class HomeController : Controller {

        public HomeController() {

        }

         public IActionResult Index() {
            return View();
         }
    }
}