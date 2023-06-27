using matriz.Core.Domain.Entities.Pizzaria;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz.Infra.Data.EntitiesConfigurarion.Pizzaria
{
    public class TamanhoConfiguration : IEntityTypeConfiguration<Tamanho>
    {
        public void Configure(EntityTypeBuilder<Tamanho> builder)
        {

            builder.HasKey(e => e.TamanhoId).HasName("PK__tamanho__01D5502F027AFF13");

            builder.ToTable("tamanho", "pizzaria");

            builder.Property(e => e.TamanhoId).HasColumnName("tamanhoId");
            builder.Property(e => e.Descricao)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descricao");
            builder.Property(e => e.NumPedaco).HasColumnName("numPedaco");

        }
    }
}
