using Microsoft.AspNetCore.Mvc;

namespace The_Bekery.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountsController : Controller
    {
        public IActionResult Index()
        {
            var accounts = MockAccounts.All();
            return View("Manage", accounts);
        }

        public IActionResult Manage()
        {
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }

    // Mock data (ชั่วคราวไว้ในไฟล์เดียวก่อน)
    public static class MockAccounts
    {
        public static List<AccountRow> All() => new()
        {
            new AccountRow { Id = 1, Name = "Admin Bakery", Email = "admin@bakery.com", Role = "Admin", Status = "Active" },
            new AccountRow { Id = 2, Name = "Oven Staff", Email = "staff1@bakery.com", Role = "Staff", Status = "Active" },
            new AccountRow { Id = 3, Name = "Customer A", Email = "user1@bakery.com", Role = "User", Status = "Active" },
            new AccountRow { Id = 4, Name = "Former Staff", Email = "staff2@bakery.com", Role = "Staff", Status = "Disabled" },
        };
    }

    public class AccountRow
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public string Role { get; set; } = "";
        public string Status { get; set; } = "";
    }
}
