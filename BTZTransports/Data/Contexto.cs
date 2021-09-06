using BTZTransports.Data.Map;
using BTZTransports.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTZTransports.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Motorista> Motorista { get; set; }
        public DbSet<Veiculo> Veiculo { get; set; }
        public DbSet<Abastecimento> Abastecimento { get; set; }
        public DbSet<Combustivel> Combustivel { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MotoristaMap());
            modelBuilder.ApplyConfiguration(new VeiculoMap());
            modelBuilder.ApplyConfiguration(new AbastecimentoMap());
            modelBuilder.ApplyConfiguration(new CombustivelMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
