using Microsoft.AspNetCore.Mvc;

namespace FlightTicketSalesSite.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
