using Huerto_Del_valle.Models;
using Microsoft.EntityFrameworkCore;

namespace Huerto_Del_valle.Controllers
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public ApplicationDbContext(DbContextOptions p) : base (p)
        {
            
        }
    }
}