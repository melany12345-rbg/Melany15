using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using proyecto_melany.Data;
using proyecto_melany.Implementacion;
using proyecto_melany.Services;

var builder = WebApplication.CreateBuilder(args);

var connectionSting = builder.Configuration
.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<DBContext>(options =>
    options.UseNpgsql(connectionSting)
);


builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IPasswordServicio, passwordServicio>();

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
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
