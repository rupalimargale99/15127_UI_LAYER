using System; 
using System.Collections.Generic; 
using System.Linq; using System.Text; 
using System.Threading.Tasks; 
using Microsoft.EntityFrameworkCore; 
using Microsoft.EntityFrameworkCore.ChangeTracking; 

namespace EFCFMastek 
{ 
    public class EFCFContext:DbContext
    { 
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; } 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer("SerVer = (localdb)\\MSSQLLocalDB;Database = EFCFDB;Integrated Security = True;");
        } 
    } 
}