using System;
using System.Collections.Generic;
using matriz.Core.Domain.Entities.PontuacaoProfessor;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace matriz.Infra.Data.EntitiesConfigurarion.PontuacaoProfessor
{
    public class SistemaConfiguration : IEntityTypeConfiguration<Sistema>
    {
        public void Configure(EntityTypeBuilder<Sistema> builder)
        {

            builder.HasKey(e => e.Id);

            builder.ToTable("sistema", "acesso");

            builder.Property(e => e.Id)
                .HasColumnName("idsistema");
            builder.Property(e => e.Descricao)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descricao");
            builder.Property(e => e.Nomenclatura)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nomenclatura");

        }
    }
}