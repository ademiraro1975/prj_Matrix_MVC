using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento>
    {
        public void Configure(EntityTypeBuilder<Departamento> builder)
        {

            builder.ToTable("tbldepartamento", "dbo");

            builder.Property(e => e.Id)
                .HasColumnName("id");
            builder.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome");
            builder.Property(e => e.Nomenclatura)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasDefaultValueSql("('Indefinido')")
                .HasColumnName("nomenclatura");

        }
    }
}
