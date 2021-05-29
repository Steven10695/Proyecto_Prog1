using Microsoft.EntityFrameworkCore;
using Proyecto_Prog1.Models;

namespace Proyecto_Prog1.Controllers
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public ApplicationDbContext(DbContextOptions p) : base (p)
        {
            
        }
    }
}