using contato_mvc.Domain.Interfaces.Repositories;
using contato_mvc.Infra.Context;
using contato_mvc.Infra.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AgendaContext>(options =>  
    options.UseNpgsql(builder.Configuration.GetConnectionString("ConexaoPadrao")));

builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IUnitOfWorkRepository, UnitOfWorkRepository>();
builder.Services.AddTransient<IContatoRepository, ContatoRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    //app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
