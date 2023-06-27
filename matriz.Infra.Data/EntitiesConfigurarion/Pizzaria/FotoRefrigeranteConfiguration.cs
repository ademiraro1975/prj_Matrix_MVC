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
    public class FotoRefrigeranteConfiguration : IEntityTypeConfiguration<FotoRefrigerante>
    {
        public void Configure(EntityTypeBuilder<FotoRefrigerante> builder)
        {

            builder.HasKey(e => e.FotoRefrigeranteId).HasName("PK__fotoRefr__9E87D26EEDCDD877");

            builder.ToTable("fotoRefrigerante", "pizzaria");

            builder.Property(e => e.FotoRefrigeranteId).HasColumnName("fotoRefrigeranteId");
            builder.Property(e => e.Foto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("foto");
            builder.Property(e => e.RefrigeranteId).HasColumnName("refrigeranteId");

            builder.HasOne(d => d.Refrigerante).WithMany(p => p.FotoRefrigerantes)
                .HasForeignKey(d => d.RefrigeranteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__fotoRefri__refri__5441852A");

        }
    }
}
