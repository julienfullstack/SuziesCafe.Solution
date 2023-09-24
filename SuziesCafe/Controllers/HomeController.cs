using Microsoft.AspNetCore.Mvc;

namespace SuziesCafe.Controllers
{
    public class HomeController : Controller
    {
    
    [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}