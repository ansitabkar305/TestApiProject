using Microsoft.AspNetCore.Mvc;

namespace MVCDotNetCore.Controllers
{
    public class HomeDateController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
