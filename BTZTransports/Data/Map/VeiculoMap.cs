using BTZTransports.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTZTransports.Data.Map
{
    public class VeiculoMap : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> builder)
        {
            builder.ToTable("Veiculo");

            //builder.HasKey(x => x.Id);

            builder.Property(x => x.Placa)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(x => x.NomeVeiculo)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.HasOne(x => x.TipoCombustivel)
                .WithMany(x => x.Veiculos)
                .HasForeignKey(x => x.IdCombustivel);

            builder.Property(x => x.Fabricante)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.AnoFabricacao)
                .HasColumnType("varchar(25)")
                .IsRequired();

            builder.Property(x => x.CapacidadeMaximaTanque)
                .HasColumnType("float")
                .IsRequired();

            builder.Property(x => x.Observacao)
                .HasColumnType("varchar(MAX)");
        }
    }
}
