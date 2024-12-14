using Demo.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ITI_ENTITY>(Optionbulider =>
{
    Optionbulider.UseSqlServer(builder.Configuration.GetConnectionString("cs"));
}
);
builder.Services.AddIdentity<Applicationuser,IdentityRole>()
    .AddEntityFrameworkStores<ITI_ENTITY>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
