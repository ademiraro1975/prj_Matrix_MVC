
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
    public class PizzaIngredienteConfiguration : IEntityTypeConfiguration<PizzaIngrediente>
    {
        public void Configure(EntityTypeBuilder<PizzaIngrediente> builder)
        {

            builder.HasKey(e => e.PizzaIngredienteId).HasName("PK__pizzaIng__122A62C4ECFAEF3D");

            builder.ToTable("pizzaIngrediente", "pizzaria");

            builder.Property(e => e.PizzaIngredienteId).HasColumnName("pizzaIngredienteId");
            builder.Property(e => e.IngredienteId).HasColumnName("ingredienteId");
            builder.Property(e => e.PizzaId).HasColumnName("pizzaId");

            builder.HasOne(d => d.Ingrediente).WithMany(p => p.PizzaIngredientes)
                .HasForeignKey(d => d.IngredienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__pizzaIngr__ingre__46E78A0C");

            builder.HasOne(d => d.Pizza).WithMany(p => p.PizzaIngredientes)
                .HasForeignKey(d => d.PizzaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__pizzaIngr__pizza__45F365D3");

        }
    }
}
