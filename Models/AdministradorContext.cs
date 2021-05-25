using Microsoft.EntityFrameworkCore;

namespace Proyecto_Prog1.Models
{
    public class AdministradorContext : DbContext
    {
        public DbSet<Administrador> Administradores {get; set;}
        public DbSet<Producto> Productos {get; set;}
        public DbSet<TipoProducto> TipoProductos{get;set;}
        public AdministradorContext(DbContextOptions dco) : base(dco){

        }
    }
}