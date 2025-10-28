using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using proyecto_melany.Models;

namespace proyecto_melany.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }
        public DbSet<usuariomodel> Usuarios { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<usuariomodel>().HasKey(U => U.UserId);
            modelBuilder.Entity<usuariomodel>().Property(U => U.UserId).ValueGeneratedOnAdd();
        }

    }
 }
