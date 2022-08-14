using Microsoft.AspNetCore.Mvc;

namespace SYSTEM.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
