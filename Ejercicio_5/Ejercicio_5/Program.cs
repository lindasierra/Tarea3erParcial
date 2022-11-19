
using Ejercicio_5;
using Ejercicio_5.Interfaces;
using Ejercicio_5.Servicios;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
Config cadenaConexion = new Config(builder.Configuration.GetConnectionString("MySql"));
builder.Services.AddSingleton(cadenaConexion);

builder.Services.AddScoped<ILoginServicio, LoginServicios>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
