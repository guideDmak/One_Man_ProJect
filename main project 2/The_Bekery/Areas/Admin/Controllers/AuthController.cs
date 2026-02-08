using Microsoft.AspNetCore.Mvc;

namespace The_Bekery.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthController : Controller
    {
        [HttpGet]
        public IActionResult Login() => View();

        [HttpPost]
        public IActionResult Login(string role)
        {
            role = (role ?? "").Trim();

            if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                return RedirectToAction("Index", "Dashboard", new { area = "Admin" });

            if (role.Equals("Staff", StringComparison.OrdinalIgnoreCase))
                return RedirectToAction("Index", "Orders", new { area = "Admin" });

            // User (ลูกค้า) -> ส่งกลับหน้าบ้าน
            return RedirectToAction("Index", "Home", new { area = "" });
        }

        [HttpGet]
        public IActionResult Register() => View();
    }
}
