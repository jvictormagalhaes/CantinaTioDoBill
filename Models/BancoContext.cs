using Microsoft.EntityFrameworkCore;

namespace CantinaDoTioBill.Models
{
    class BancoContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Rota> Rota { get; set; }
        public DbSet<TelaVenda> TelaVenda { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) {
            options.UseSqlite("Data Source=C:\\Users\\vitor\\OneDrive\\Área de Trabalho\\Curso C# Completo\\Cantinha do tio Bill\\CantinaDoTioBill\\Banco.db");
        }
    }
}
