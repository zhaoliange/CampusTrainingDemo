var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();
var app = builder.Build();
app.UseSession();
//app.MapGet("/", () => "Hello World!");

app.Run(async (context) =>
{
    string message;
    if (!context.Request.Cookies.TryGetValue("Sample", out message))
    {
        message = "Save data to cookies.";
    }
    context.Response.Cookies.Append("Sample", "This is Cookies.");
    // 刪除 Cookies 数据
    //context.Response.Cookies.Delete("Sample");
    await context.Response.WriteAsync($"{message}");

});

app.Run(async (context) =>
{
    context.Session.SetString("Sample", "This is Session.");
    string message = context.Session.GetString("Sample");
    await context.Response.WriteAsync($"{message}");
});

app.Run();
