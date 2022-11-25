using Microsoft.EntityFrameworkCore;
using MVC_EFexample.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSession();
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<companyContext>(options =>
       options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddSession(s => s.IdleTimeout = TimeSpan.FromMinutes(30));

var app = builder.Build();
app.UseSession();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=user}/{action=login}/{id?}");

app.Run();
