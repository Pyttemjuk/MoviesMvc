using Microsoft.EntityFrameworkCore;
using MoviesMvc.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<DataService>();

var connstring = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationContext>(o => o.UseSqlServer(connstring));

var app = builder.Build();

app.UseRouting();
app.UseEndpoints(o => o.MapControllers());
app.UseStaticFiles();

app.Run();
