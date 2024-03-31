using CarService.Data;
using CarService.Data.Entities;
using CarService.Repository;
using CarService.Repository.Interface;
using CarService.Service;
using CarService.Service.Interface;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

var builder = WebApplication.CreateBuilder(args);
string connectionString = builder.Configuration.GetConnectionString("ApplicationContextConnectionString") ??
                throw new InvalidOperationException("Connection string ApplicationContextConnectionString is not found");


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationContext>(options =>
    options.UseMySQL(builder.Configuration.GetConnectionString("ApplicationContextConnectionString")));


builder.Services.AddScoped<IAutoPartsRepository, AutoPartsRepository>();
builder.Services.AddScoped<IAutoPartsService, AutoPartsService>(); 
builder.Services.AddRazorPages();
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
    pattern: "{controller=AutoParts}/{action=Index}/{id?}");

app.Run();
