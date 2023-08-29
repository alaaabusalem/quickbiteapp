using FoodiApp.Data;
using FoodiApp.Models;
using FoodiApp.Models.Interfaces;
using FoodiApp.Models.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


// adding services to Db context
string connString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services
.AddDbContext<FoodieDBContext>
	(opions => opions.UseSqlServer(connString));

builder.Services.AddTransient<IFoodCategory, FoodCategoryService>();

var app = builder.Build();

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
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
