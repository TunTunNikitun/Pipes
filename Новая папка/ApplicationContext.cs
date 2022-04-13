using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskForTMK.Models;

namespace TestTaskForTMK
{
    public class ApplicationContext : DbContext
    {
        public DbSet<PipesModel> Pipes { get; set; }
        public DbSet<Packages> Packages { get; set; }
        public DbSet<Steel> Steel { get; set; }
        public DbSet<PackageStructure> PackageStructure { get; set; }

        public ApplicationContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Updatedb;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PipesModel>().HasKey(x => x.Id);
            modelBuilder.Entity<Packages>().HasKey(x => x.Id);
            modelBuilder.Entity<Steel>().HasKey(x => x.Id);
            modelBuilder.Entity<PackageStructure>().HasKey(x => x.Id);
        }
    }
}
