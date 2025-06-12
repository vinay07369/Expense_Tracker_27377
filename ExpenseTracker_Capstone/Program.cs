using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ExpenseTracker_Capstone.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ExpenseTracker_CapstoneContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ExpenseTracker_CapstoneContext") ?? throw new InvalidOperationException("Connection string 'ExpenseTracker_CapstoneContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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
