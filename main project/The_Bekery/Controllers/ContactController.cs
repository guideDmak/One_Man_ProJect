using Microsoft.AspNetCore.Mvc;

namespace The_Bekery.Controllers;

public class ContactController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
}
