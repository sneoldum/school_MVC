using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI2.Controllers
{
    public class ForgotController : Controller
    {

       
        public IActionResult Index()
        {
            return View();
        }
    }
}
