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
    public class IngredienteConfiguration : IEntityTypeConfiguration<Ingrediente>
    {
        public void Configure(EntityTypeBuilder<Ingrediente> builder)
        {

            builder.HasKey(e => e.IngredienteId).HasName("PK__ingredie__BD695E807FD9EB0F");

            builder.ToTable("ingrediente", "pizzaria");

            builder.Property(e => e.IngredienteId)
                .HasColumnName("ingredienteId");
            builder.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ingrediente");

        }
    }
}
