using matriz.Core.Domain.Entities.PontuacaoProfessor;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace matriz.Infra.Data.EntitiesConfigurarion.PontuacaoProfessor
{
    public class DisciplinaConfiguration : IEntityTypeConfiguration<Disciplina>
    {
        public void Configure(EntityTypeBuilder<Disciplina> builder)
        {

            builder.HasKey(e => e.Id).HasName("PK__tbldisci__3213E83F5CD6CB2B");

            builder.ToTable("tbldisciplina", "dbo");

            builder.Property(e => e.Id)
                .HasColumnName("id");
            builder.Property(e => e.Codigo)
                .HasColumnName("codigo");
            builder.Property(e => e.Nome)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nome");
            builder.Property(e => e.Sigla)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("sigla");

        }
    }
}
