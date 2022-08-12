using ConfigurationDemo;

var builder = WebApplication.CreateBuilder(args);
/*
builder.Host.ConfigureAppConfiguration((hostingContext, config) =>
{
    config.AddJsonFile("MyConfig.json",
                       optional: true,
                       reloadOnChange: true);
});
*/
builder.Services.AddRazorPages();
builder.Services.Configure<PositionOptions>(
    builder.Configuration.GetSection(PositionOptions.Position));
var app = builder.Build();
app.UseRouting();
app.MapRazorPages();
app.Run();
