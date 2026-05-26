using Lesson2.Repositories;
using Lesson2.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

// Регистрация зависимости: интерфейс - реализация
builder.Services.AddTransient<IMemeRepository, MemeRepository>();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseRouting();
app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();