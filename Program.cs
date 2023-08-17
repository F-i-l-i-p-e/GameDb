using GameDb.Data; // Data Namespace
using Microsoft.EntityFrameworkCore; // EF Core Namespace

var builder = WebApplication.CreateBuilder(args); // Create Builder

// Add services to the container.
builder.Services.AddControllersWithViews(); // Add MVC

// Add database context
builder.Services.AddDbContext<DBContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"))); // Add DB Context

var app = builder.Build(); // Build App

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) // Not Development
{
    app.UseExceptionHandler("/Home/Error"); // Error Handling
    app.UseHsts(); // Use HSTS
}

app.UseHttpsRedirection(); // HTTPS Redirect
app.UseStaticFiles(); // Static Files

app.UseRouting(); // Use Routing

app.UseAuthorization(); // Use Authorization

app.MapControllerRoute( // Map Route
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run(); // Run App
