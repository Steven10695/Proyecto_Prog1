using app.Models;
using Microsoft.EntityFrameworkCore;

namespace app.Controllers
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public ApplicationDbContext(DbContextOptions p) : base (p)
        {
            
        }
    }
}