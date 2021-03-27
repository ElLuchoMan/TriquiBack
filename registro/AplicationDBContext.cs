using Microsoft.EntityFrameworkCore;
using registro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace registro
{
      public class AplicationDBContext : DbContext
    {
        public DbSet<Registro> Registro { get; set; }
       
        public AplicationDBContext(DbContextOptions<AplicationDBContext> options) : base(options)

        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Registro>()
                .HasKey(r => new {r.Password, r.Correo });
        }


    }
}
