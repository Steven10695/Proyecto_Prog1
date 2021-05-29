using plantitas.Models;
using Microsoft.EntityFrameworkCore;

namespace plantitas.Controllers
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public ApplicationDbContext(DbContextOptions p) : base (p)
        {
            
        }
    }
}