using BitacoraApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BitacoraApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Suma> Sumas{ get; set; } 
        public DbSet<Bitacora> Bitacoras{ get; set; }  
        public DbSet<Resta> Restas{ get; set; }  
        public DbSet<Multi> Multis{ get; set; }  
        public DbSet<Divicion> Divicions{ get; set; }  
        public DbSet<Raiz> Raiz_ { get; set; }  
        public DbSet<Exponencial> Exponencials { get; set; }  

    }
}