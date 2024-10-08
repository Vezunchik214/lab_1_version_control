using Microsoft.AspNetCore.Mvc;

namespace YourAppNamespace.Controllers
{
    public class ResolveController : Controller
    {
        
        public IActionResult Show()
        {
            ViewData["Message"] = "Це нове представлення, створене в ResolveController.";
            return View();
        }
    }
}
