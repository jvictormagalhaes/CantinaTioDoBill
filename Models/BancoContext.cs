﻿using Microsoft.EntityFrameworkCore;

namespace CantinaDoTioBill.Models
{
    class BancoContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<TipoQuentinha> TipoQuentinha { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) {
            options.UseSqlite("Data Source=banco.db");
        }
    }
}
