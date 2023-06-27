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
    public class PizzaConfiguration : IEntityTypeConfiguration<Pizza>
    {
        public void Configure(EntityTypeBuilder<Pizza> builder)
        {

            builder.HasKey(e => e.PizzaId).HasName("PK__pizza__4D4C90EFEF78B275");

            builder.ToTable("pizza", "pizzaria");

            builder.Property(e => e.PizzaId).HasColumnName("pizzaId");
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
