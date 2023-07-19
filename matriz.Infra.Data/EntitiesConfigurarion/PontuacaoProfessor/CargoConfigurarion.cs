using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using matriz.Core.Domain.Entities.PontuacaoProfessor;

namespace matriz.Infra.Data.EntitiesConfigurarion.PontuacaoProfessor
{
    public class CargoConfiguration : IEntityTypeConfiguration<Cargo>
    {
        public void Configure(EntityTypeBuilder<Cargo> builder)
        {

            builder.ToTable("tblcargo", "dbo");

            builder.Property(e => e.Id)
                .HasColumnName("id");
            builder.Property(e => e.Nomenclatura)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("nomenclatura");
            builder.Property(e => e.Titulo)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("titulo");

        }
    }
}
