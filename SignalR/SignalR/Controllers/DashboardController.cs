using Microsoft.AspNetCore.Mvc;

namespace SignalR.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
