using Microsoft.EntityFrameworkCore;

namespace SistemFinanciarIndividual.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options) { }
        public DbSet<Tranzactii> Tranzactii { get; set; }
        public DbSet<Categorie> Categorie { get; set; }

    }
}
