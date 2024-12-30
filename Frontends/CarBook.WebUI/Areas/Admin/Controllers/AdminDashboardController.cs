using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
    public class AdminDashboardController : Controller
    {
        [Area("Admin")]
        [Route("Admin/AdminDashboard")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
