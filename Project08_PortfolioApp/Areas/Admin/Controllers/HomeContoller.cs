using Microsoft.AspNetCore.Mvc;

namespace Project08_PortfolioApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeContoller : Controller
    {
        // GET: HomeContoller
        public ActionResult Index()
        {
            return View();
        }

    }
}
