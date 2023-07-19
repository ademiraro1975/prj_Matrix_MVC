using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using matriz.Core.Domain.Entities.PontuacaoProfessor;

namespace matriz.Infra.Data.EntitiesConfigurarion.PontuacaoProfessor
{
    public class AtribuicaoConfigurarion : IEntityTypeConfiguration<Atribuicao>
    {
        public void Configure(EntityTypeBuilder<Atribuicao> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK_tblatribuicao");

            builder.ToTable("tblatribuicao", "dbo");

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.Descricao)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descricao");
            builder.Property(e => e.Nomenclatura)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nomenclatura");
            builder.Property(e => e.Titulo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("titulo");

        }
    }
}
