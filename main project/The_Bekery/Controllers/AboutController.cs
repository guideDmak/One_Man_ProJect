using Microsoft.AspNetCore.Mvc;

namespace The_Bekery.Controllers;

public class AboutController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
}
