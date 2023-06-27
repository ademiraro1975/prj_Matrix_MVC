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
    public class RefrigeranteConfiguration : IEntityTypeConfiguration<Refrigerante>
    {
        public void Configure(EntityTypeBuilder<Refrigerante> builder)
        {

            builder.HasKey(e => e.RefrigeranteId).HasName("PK__refriger__49D5E5E040B12433");

            builder.ToTable("refrigerante", "pizzaria");

            builder.Property(e => e.RefrigeranteId).HasColumnName("refrigeranteId");
            builder.Property(e => e.Descricao)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descricao");
            builder.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome");

        }
    }
}
