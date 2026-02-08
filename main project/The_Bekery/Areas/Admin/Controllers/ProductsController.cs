using Microsoft.AspNetCore.Mvc;

namespace The_Bekery.Areas.Admin.Controllers;

[Area("Admin")]
public class ProductsController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
}
