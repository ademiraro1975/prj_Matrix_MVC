using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using matriz.Core.Domain.Entities.Pizzaria;

namespace matriz.Infra.Data.EntitiesConfigurarion.Pizzaria
{
    public class FotoPizzaConfiguration : IEntityTypeConfiguration<FotoPizza>
    {
        public void Configure(EntityTypeBuilder<FotoPizza> builder)
        {

            builder.HasKey(e => e.FotoPizzaId).HasName("PK__fotoPizz__FCB4389590003220");

            builder.ToTable("fotoPizza", "pizzaria");

            builder.Property(e => e.FotoPizzaId).HasColumnName("fotoPizzaId");
            builder.Property(e => e.Foto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("foto");
            builder.Property(e => e.PizzaId).HasColumnName("pizzaId");

            builder.HasOne(d => d.Pizza).WithMany(p => p.FotoPizzas)
                .HasForeignKey(d => d.PizzaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__fotoPizza__pizza__49C3F6B7");

        }
    }
}
