using Microsoft.AspNetCore.Mvc;

namespace The_Bekery.Controllers;

public class ShopController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
}
