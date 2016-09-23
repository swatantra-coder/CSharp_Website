using System.Data.Entity;

namespace WebApplication1.Models
{
    public class MetierDBContext : DbContext
    {
        public DbSet<Metier> Metiers { get; set; }
    }
}