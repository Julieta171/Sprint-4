//Contexto de la base de datos.


using Microsoft.EntityFrameworkCore;
using MoviesSeries.Models;

namespace MoviesSeries.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Series> Series { get; set; }
    }
}
