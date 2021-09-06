using BTZTransports.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTZTransports.Data.Map
{
    public class MotoristaMap : IEntityTypeConfiguration<Motorista>
    {
        public void Configure(EntityTypeBuilder<Motorista> builder)
        {
            builder.ToTable("Motorista");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.Cpf)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(x => x.Cnh)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(x => x.CategoriaCnh)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(x => x.DataNascimento)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(x => x.Status)
                .HasColumnType("bit")
                .IsRequired();
        }
    }
}
