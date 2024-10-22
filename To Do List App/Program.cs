using To_Do_List_App.Interfaces;
using To_Do_List_App.Services;
using Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews()
.AddRazorRuntimeCompilation();

builder.Services.AddSingleton<ITodoService, TodoService>();

builder.Services.AddTransient<ITaskLogger, TaskLogger>();

builder.Services.AddSingleton<IAppSettings, AppSettings>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=ToDo}/{action=Index}/{id?}");

app.Run();
