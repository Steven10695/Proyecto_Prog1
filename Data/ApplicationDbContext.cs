using System;
using System.Collections.Generic;
using System.Text;
using Huerto_Del_valle.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Proyecto_Prog1.Models;


namespace Huerto_Del_valle.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Consulta> Consulta { get; set; }
        public DbSet<Reclamo> Reclamo { get; set; }
     
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
     
        public DbSet<Proyecto_Prog1.Models.Proforma> Proforma { get; set; }
    }
}
