using Calculatrice_TP2.Data;
using Calculatrice_TP2.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// MVC
builder.Services.AddControllersWithViews();

// Base de données SQLite
builder.Services.AddDbContext<CalculatriceContext>(options =>
    options.UseSqlite("Data Source=calculatrice.db"));

// Service de calcul
builder.Services.AddScoped<CalculService>();

var app = builder.Build();

// Pipeline HTTP TRÈS important pour gérer les erreurs, rediriger vers HTTPS, servir les fichiers statiques, configurer le routage et l'autorisation
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Route MVC par défaut qui redirige vers le contrôleur Calculatrice et l'action Index si aucune route n'est spécifiée
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Calculatrice}/{action=Index}/{id?}");

app.Run();