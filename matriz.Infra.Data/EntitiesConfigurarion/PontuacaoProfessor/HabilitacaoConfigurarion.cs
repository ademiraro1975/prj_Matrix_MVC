using matriz.Core.Domain.Entities.PontuacaoProfessor;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace matriz.Infra.Data.EntitiesConfigurarion.PontuacaoProfessor
{
    public class HabilitacaoConfiguration : IEntityTypeConfiguration<Habilitacao>
    {
        public void Configure(EntityTypeBuilder<Habilitacao> builder)
        {

            builder.HasKey(e => e.Id)
                .HasName("PK__tblhabil__3213E83F5165187F");

            builder.ToTable("tblhabilitacao", "dbo");

            builder.Property(e => e.Id)
                .HasColumnName("id");
            builder.Property(e => e.Descricao)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("descricao");

        }
    }
}