using CantinaDoTioBill.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;

namespace CantinaDoTioBill.Controller
{
    public class BancoContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Rota> Rota { get; set; }
        public DbSet<TelaVenda> TelaVenda { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=VICTOR\\;Initial Catalog=Banco;Integrated Security=True");
        }
    }
}