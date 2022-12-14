using DependencyInjectionDemo;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
//builder.Services.AddMyDependencyGroup();
builder.Services.AddRazorPages();
builder.Services.AddScoped<IMyDependency, MyDependency>();
//builder.Services.AddScoped<IMyDependency, MyDependency2>();

builder.Services.AddTransient<IOperationTransient, Operation>();
builder.Services.AddScoped<IOperationScoped, Operation>();
builder.Services.AddSingleton<IOperationSingleton, Operation>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseMyMiddleware();
app.UseRouting();

app.UseAuthorization();
app.MapRazorPages();

app.Run();
