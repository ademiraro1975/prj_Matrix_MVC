using matriz.Core.Domain.Entities.PontuacaoProfessor;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace matriz.Infra.Data.EntitiesConfigurarion.PontuacaoProfessor
{
    public class GrupoDisciplinaConfiguration : IEntityTypeConfiguration<GrupoDisciplina>
    {
        public void Configure(EntityTypeBuilder<GrupoDisciplina> builder)
        {

            builder.ToTable("tblgrupodisciplina", "dbo");

            builder.Property(e => e.Id)
                .HasColumnName("id");
            builder.Property(e => e.Descricao)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descricao");
            builder.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo");

        }
    }
}
