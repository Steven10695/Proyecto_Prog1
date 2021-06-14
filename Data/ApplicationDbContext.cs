using System;
using System.Collections.Generic;
using System.Text;
using Huerto_Del_valle.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Huerto_Del_valle.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Consulta> Consulta { get; set; }
        public DbSet<Reclamo> Reclamo { get; set; }
        public DbSet<Proforma> Proforma { get; set; }
        public DbSet<Pago> Pago { get; set; }
        public DbSet<Calificacion> Calificacion { get; set; }
     
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
