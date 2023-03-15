using MoviesMvc.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<DataService>();

var app = builder.Build();

app.UseRouting();
app.UseEndpoints(o => o.MapControllers());
app.UseStaticFiles();

app.Run();
