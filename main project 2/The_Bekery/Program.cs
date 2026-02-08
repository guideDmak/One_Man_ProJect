using Westwind.AspNetCore.LiveReload;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();




// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
    app.UseHttpsRedirection();
}
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

// Area route (รองรับ Areas/Admin/Controllers/*)
app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Auth}/{action=Login}/{id?}");

// admin prefix route (เข้าผ่าน /admin/... แต่ยังใช้ Area Admin)
app.MapControllerRoute(
    name: "admin-area",
    pattern: "admin/{controller=Auth}/{action=Login}/{id?}",
    defaults: new { area = "Admin" });

// default public
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");





app.Run();
