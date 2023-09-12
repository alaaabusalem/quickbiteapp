using FoodiApp.Data;
using FoodiApp.Models;
using FoodiApp.Models.Interfaces;
using FoodiApp.Models.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();


// adding services to Db context
string connString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services
.AddDbContext<FoodieDBContext>
	(opions => opions.UseSqlServer(connString));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
{
	options.User.RequireUniqueEmail = true;
}).AddEntityFrameworkStores<FoodieDBContext>();

//builder.Services.AddScoped<JwtTokenService>();

builder.Services.AddTransient<IUpload, UploadService>();

builder.Services.AddTransient<IFoodCategory, FoodCategoryService>();

builder.Services.AddTransient<IUser, UserService>();

builder.Services.AddTransient<IFoodItems, FoodItemService>();


builder.Services.AddAuthentication(
//options =>
//{
//	options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
//	options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//	options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
//}).AddJwtBearer(options =>
//{
//	// Tell the authenticaion scheme "how/where" to validate the token + secret
//	options.TokenValidationParameters = JwtTokenService.GetValidationPerameters(builder.Configuration);
//}
);

builder.Services.AddAuthorization();

builder.Services.ConfigureApplicationCookie(options =>
{
	options.ExpireTimeSpan = TimeSpan.FromMinutes(10);
	options.LoginPath = "/Auth/Login";
});

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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
