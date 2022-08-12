var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseHttpLogging();
app.MapGet("/", () => "Hello World!");

app.Run();
