using Microsoft.AspNetCore.Mvc;

namespace BlackjackStatsTracker.Controllers
{
    public class BlackjackController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Kartları listelemek ve istatistikleri göstermek için metodlar ekleyeceğiz.
    }
}
