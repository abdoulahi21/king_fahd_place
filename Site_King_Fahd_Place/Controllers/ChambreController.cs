using Microsoft.AspNetCore.Mvc;
using Site_King_Fahd_Place.Models;
using System.Diagnostics;

namespace Site_King_Fahd_Place.Controllers
{
    public class ChambreController : Controller
    {
        private readonly ILogger<ChambreController> _logger;

        public ChambreController(ILogger<ChambreController> logger)
        {
            _logger = logger;
        }

      



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
