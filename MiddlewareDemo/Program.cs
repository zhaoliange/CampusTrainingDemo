using MiddlewareDemo;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Hello from 1nd delegate before  ");
    await next.Invoke();
    await context.Response.WriteAsync("Hello from 1nd delegate after.  ");
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Hello from 2nd delegate before  ");
    await next.Invoke();
    await context.Response.WriteAsync("Hello from 2nd delegate after.  ");
});

app.Run(async context =>
{
    await context.Response.WriteAsync("Hello from 3nd delegate.  ");
});
/*
app.Use(async (context, next) =>
{
    var cultureQuery = context.Request.Query["culture"];
    if (!string.IsNullOrWhiteSpace(cultureQuery))
    {
        var culture = new CultureInfo(cultureQuery);

        CultureInfo.CurrentCulture = culture;
        CultureInfo.CurrentUICulture = culture;
    }

    // Call the next delegate/middleware in the pipeline.
    await next(context);
});

app.Run(async context =>
{
    await context.Response.WriteAsync("Hello world!");
});

app.UseRequestCulture();

app.Run(async (context) =>
{
    await context.Response.WriteAsync(
        $"CurrentCulture.DisplayName: {CultureInfo.CurrentCulture.DisplayName}");
});
*/
app.Run();

