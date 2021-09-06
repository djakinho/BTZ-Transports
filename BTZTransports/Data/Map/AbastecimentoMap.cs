using BTZTransports.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTZTransports.Data.Map
{
    public class AbastecimentoMap : IEntityTypeConfiguration<Abastecimento>
    {
        public void Configure(EntityTypeBuilder<Abastecimento> builder)
        {
            builder.ToTable("Abastecimento");

            //builder.HasKey(x => x.Id);

            builder.Property(x => x.Data)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(x => x.QuantidadeAbastecida)
                .HasColumnType("float")
                .IsRequired();


            builder.Property(x => x.IdCombustivel)
                .HasColumnType("int")
                .IsRequired();
            //builder.HasOne(x => x.Veiculo.TipoCombustivel)
            //    .WithMany(x => x.Abastecimentos)
            //    .HasForeignKey(x => x.IdCombustivel)
            //    ;

            builder.HasOne(x => x.Motorista)
                .WithMany(x => x.Abastecimentos)
                .HasForeignKey(x => x.IdMotorista);

            builder.HasOne(x => x.Veiculo)
                .WithMany(x => x.Abastecimentos)
                .HasForeignKey(x => x.IdVeiculo);
        }
    }
}
