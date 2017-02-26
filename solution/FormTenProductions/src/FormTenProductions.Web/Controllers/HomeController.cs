using FormTenProductions.Web.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace FormTenProductions.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(new LayoutViewModel
            {
                Title = "Home"
            });
        }

        public IActionResult Artists()
        {
            return View(new LayoutViewModel
            {
                Title = "Artists"
            });
        }

        public IActionResult Music()
        {
            return View(new LayoutViewModel
            {
                Title = "Music"
            });
        }

        public IActionResult SocialMedia()
        {
            return View(new LayoutViewModel
            {
                Title = "Social Media"
            });
        }
    }
}
