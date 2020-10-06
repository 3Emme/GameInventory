using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace GameInventory.Controllers
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