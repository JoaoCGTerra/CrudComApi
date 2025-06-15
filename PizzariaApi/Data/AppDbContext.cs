using Pizzaria.Models;
using Microsoft.EntityFrameworkCore;

namespace Pizzaria.Data{
    public class AppDbContext : DbContext {
        public DbSet<Tb_cliente> Tb_cliente { get; set; }
        public DbSet<Tb_pizza> Tb_pizza { get; set; }
        public DbSet<Tb_sobremesa> Tb_sobremesa { get; set; }
        public DbSet<Tb_bebida> Tb_bebida { get; set; }
        public DbSet<Tb_filiais> Tb_filiais { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("DataSource=Pizzaria.db;Cache=Shared");
    }

}