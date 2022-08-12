using DependencyInjectionMvcDemo;
using DependencyInjectionMvcDemo.Infrastructure;
using DependencyInjectionMvcDemo.Interfaces;
using DependencyInjectionMvcDemo.Models.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Host.ConfigureAppConfiguration((hostingContext, config) =>
{
    config.AddJsonFile("samplewebsettings.json",
                    optional: false,
                    reloadOnChange: true);
});
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.Configure<SampleWebSettings>(builder.Configuration);
builder.Services.AddSingleton<IDateTime, SystemDateTime>();
builder.Services.AddTransient<IToDoItemRepository, ToDoItemRepository>();
builder.Services.AddTransient<StatisticsService>();
builder.Services.AddTransient<ProfileOptionsService>();
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
