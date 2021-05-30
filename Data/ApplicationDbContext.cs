﻿using System;
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
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
