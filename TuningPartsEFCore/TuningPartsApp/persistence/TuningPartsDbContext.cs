using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuningPartsApp.models;

namespace TuningPartsApp.persistence
{
    public class TuningPartsDbContext : DbContext
    {

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Model> Models { get; set; }

        public string DbPath { get; }


        public TuningPartsDbContext()
        {
            var folder = Environment.SpecialFolder.ApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "tuningparts.db");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var brands = new[] {
                new Brand() { Id = Guid.NewGuid(), Name = "Ducati", Description = "The coolest motor bike", Founder = "Hr Ducati" },
                new Brand() { Id = Guid.NewGuid(), Name = "Harley-Davidson", Description = "Iconic American motorcycle manufacturer", Founder = "William S. Harley and Arthur Davidson" },
                new Brand() { Id = Guid.NewGuid(), Name = "Honda", Description = "Japanese multinational conglomerate", Founder = "Soichiro Honda" },
                new Brand() { Id = Guid.NewGuid(), Name = "Kawasaki", Description = "Japanese multinational corporation known for motorcycles, heavy equipment, aerospace and defense equipment, rolling stock and ships.", Founder = "Shozo Kawasaki" },
                new Brand() { Id = Guid.NewGuid(), Name = "BMW Motorrad", Description = "German multinational company which currently produces luxury automobiles and motorcycles.", Founder = "Franz Josef Popp, Karl Rapp, and Camillo Castiglioni" },
                new Brand() { Id = Guid.NewGuid(), Name = "Suzuki", Description = "Japanese multinational corporation headquartered in Minami-ku, Hamamatsu, Japan.", Founder = "Michio Suzuki" },
                new Brand() { Id = Guid.NewGuid(), Name = "Yamaha", Description = "Japanese multinational corporation headquartered in Iwata, Shizuoka, Japan.", Founder = "Torakusu Yamaha" },
                new Brand() { Id = Guid.NewGuid(), Name = "Triumph", Description = "British motorcycle manufacturing company, based originally in Coventry and then in Meriden.", Founder = "John Bloor" },
                new Brand() { Id = Guid.NewGuid(), Name = "Aprilia", Description = "Italian motorcycle company, one of the marques owned by Piaggio.", Founder = "Alberto Beggio" },
                new Brand() { Id = Guid.NewGuid(), Name = "Indian Motorcycle", Description = "American brand of motorcycles originally produced from 1901 to 1953 in Springfield, Massachusetts, United States.", Founder = "George M. Hendee, Oscar Hedstrom" }
            };
            modelBuilder.Entity<Brand>().HasData(brands);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }

        private static TuningPartsDbContext _context = null;

        public static TuningPartsDbContext getInstance()
        {
            if (_context == null)
            {
                _context = new TuningPartsDbContext();
            }
            return _context;
        }

    }
}
