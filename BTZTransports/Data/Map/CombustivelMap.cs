using BTZTransports.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTZTransports.Data.Map
{
    public class CombustivelMap : IEntityTypeConfiguration<Combustivel>
    {
        public void Configure(EntityTypeBuilder<Combustivel> builder)
        {
            builder.ToTable("Combustivel");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(x => x.Preco)
                .HasColumnType("money")
                .IsRequired();
        }
    }
}
