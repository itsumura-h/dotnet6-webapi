using Microsoft.AspNetCore.Mvc;

namespace src.Controllers;

[Route("")]
public class IndexController : Controller
{
  [HttpGet()]
  public IActionResult Index()
  {
    return View("Views/IndexView.cshtml");
  }
}
