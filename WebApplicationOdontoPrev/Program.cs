using Microsoft.EntityFrameworkCore;
using WebApplicationOdontoPrev.Data;
using WebApplicationOdontoPrev.Models;
using WebApplicationOdontoPrev.Repositories.Implementations;
using WebApplicationOdontoPrev.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseOracle(builder.Configuration.GetConnectionString("OracleConnection"));
});
builder.Services.AddScoped<IPacienteRepository, PacienteRepository>();
builder.Services.AddScoped<IDentistaRepository, DentistaRepository>();
builder.Services.AddScoped<IPlanoRepository, PlanoRepository>();
builder.Services.AddScoped<IExtratoPontosRepository, ExtratoPontosRepository>();
builder.Services.AddScoped<IRaioXRepository, RaioXRepository>();
builder.Services.AddScoped<IAnaliseRaioXRepository, AnaliseRaioXRepository>();
builder.Services.AddScoped<IPerguntasRepository, PerguntasRepository>();
builder.Services.AddScoped<IRespostasRepository, RespostasRepository>();


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
