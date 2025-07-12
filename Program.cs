using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using shop_asp_net_core_mvc.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<WebMVCContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebMVCContext") ?? throw new InvalidOperationException("Connection string 'WebMVCContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
