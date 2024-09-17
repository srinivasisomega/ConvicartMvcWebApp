using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ConvicartMvcWebApp.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ConvicartMvcWebAppContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConvicartMvcWebAppContext") ?? throw new InvalidOperationException("Connection string 'ConvicartMvcWebAppContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsProduction())
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
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Users}/{action=Index}/{id?}");

app.Run();
