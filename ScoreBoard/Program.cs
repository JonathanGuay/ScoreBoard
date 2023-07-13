using Microsoft.EntityFrameworkCore;
using ScoreBoard.Models;
using ScoreBoard.ViewModels;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IJoueurRepository, bdJoueurRep>();


//Mettre ici le code pour le chemin d'accès vers la connexion pour la database
builder.Services.AddDbContext<ScoreBoardDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration["ConnectionStrings:ScoreBoardDbContextConnection"]); //inscrire la référence à la chaine de connexion
});

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dashboard}/{action=Index}/{id?}");



app.Run();
