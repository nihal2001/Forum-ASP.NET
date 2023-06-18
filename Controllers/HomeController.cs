using Microsoft.AspNetCore.Mvc;

namespace Forum.Controllers {

    public class HomeController : Controller {

        private readonly IPostService _postService;

        public HomeController(IPostService postService) {
            _postService = postService;
        }

         public IActionResult Index() {
            return View();
         }
    }
}