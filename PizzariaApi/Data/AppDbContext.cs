using Pizzaria.Models;
using Microsoft.EntityFrameworkCore;

namespace Pizzaria.Data{
    public class AppDbContext : DbContext {
        public DbSet<tb_cadastro_cliente> tb_cadastro_cliente { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("DataSource=Pízzaria.db;Cache=Shared");
    }

}