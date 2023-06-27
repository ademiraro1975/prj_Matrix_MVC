
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
    public class TipoConfiguration : IEntityTypeConfiguration<Tipo>
    {
        public void Configure(EntityTypeBuilder<Tipo> builder)
        {

            builder.HasKey(e => e.TipoId).HasName("PK__tipo__2AF60263BDDAA0D1");

            builder.ToTable("tipo", "pizzaria");

            builder.Property(e => e.TipoId).HasColumnName("tipoId");
            builder.Property(e => e.Descricao)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descricao");

        }
    }
}
