using Microsoft.AspNetCore.Mvc;

namespace The_Bekery.Areas.Admin.Controllers;

[Area("Admin")]
public class OrdersController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
}
