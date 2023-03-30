using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Rowerowowo.InMemoryDbContext;
using Rowerowowo.Mapping;
using Rowerowowo.Models;
using Rowerowowo.Repository;
using Rowerowowo.ViewModels;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<InMemoryDBContext>(options => options.UseInMemoryDatabase("ATHBikeReantingDatabase"));

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

builder.Services.AddAutoMapper(typeof(OrganizationProfile));

var app = builder.Build();

await CreateDB(app);
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

async Task CreateDB(IHost host)
{
    await using var scope = host.Services.CreateAsyncScope();
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<InMemoryDBContext>();
    await Seeder.Seed(context);
}
