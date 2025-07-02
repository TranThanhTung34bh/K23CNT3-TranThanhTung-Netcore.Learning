using Microsoft.EntityFrameworkCore;
using TranThanhTung_2310900115.Models;

var builder = WebApplication.CreateBuilder(args);

// ✅ Đăng ký DbContext với chuỗi kết nối trong appsettings.json
builder.Services.AddDbContext<TranThanhTung2310900115Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TttDbConnection")));

builder.Services.AddControllersWithViews();

var app = builder.Build();

// ✅ Cấu hình pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// ✅ Định tuyến mặc định tới TttEmployeesController → TttIndex
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=TttEmployees}/{action=TttIndex}/{id?}");

app.Run();
