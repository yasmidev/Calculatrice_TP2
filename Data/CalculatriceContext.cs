using Calculatrice_TP2.Models;
using Microsoft.EntityFrameworkCore;

//database context
namespace Calculatrice_TP2.Data
{
    public class CalculatriceContext : DbContext
    {
        public CalculatriceContext(DbContextOptions<CalculatriceContext> options)
            : base(options)
        {
        }

        public DbSet<Calcul> Calculs { get; set; } = null!;

// seeding
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Calcul>().HasData(
                new Calcul
                {
                    Id = 1,
                    Equation = "2 + 2",
                    Resultat = 4,
                    Date = new DateTime(2024, 1, 1)
                }
            );
        }
    }
}