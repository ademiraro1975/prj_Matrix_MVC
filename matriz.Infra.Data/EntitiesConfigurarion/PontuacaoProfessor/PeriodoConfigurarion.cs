using matriz.Core.Domain.Entities.PontuacaoProfessor;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace matriz.Infra.Data.EntitiesConfigurarion.PontuacaoProfessor
{
    public class PeriodoConfiguration : IEntityTypeConfiguration<Periodo>
    {
        public void Configure(EntityTypeBuilder<Periodo> builder)
        {

            builder.ToTable("tblperiodo", "dbo");

            builder.Property(e => e.Id)
                .HasColumnName("id");
            builder.Property(e => e.HoraFim)
                .HasColumnName("horafim");
            builder.Property(e => e.HoraInicio)
                .HasColumnName("horainicio");
            builder.Property(e => e.Nome)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("nome");
            builder.Property(e => e.Sigla)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sigla");

        }
    }
}