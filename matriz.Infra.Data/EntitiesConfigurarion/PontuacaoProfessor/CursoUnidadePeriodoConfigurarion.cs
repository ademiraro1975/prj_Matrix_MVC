using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public class CursoUnidadePeriodoConfiguration : IEntityTypeConfiguration<CursoUnidadePeriodo>
    {
        public void Configure(EntityTypeBuilder<CursoUnidadePeriodo> builder)
        {

            builder.ToTable("tblcursounidadeperiodo", "dbo");

            builder.Property(e => e.Id)
                .HasColumnName("id");
            builder.Property(e => e.HoraFim)
                .HasColumnName("horafim");
            builder.Property(e => e.HoraInicio)
                .HasColumnName("horainicio");
            builder.Property(e => e.CursoUnidadeId)
                .HasColumnName("idcursounidade");
            builder.Property(e => e.PeriodoId)
                .HasColumnName("idperiodo");

            builder.HasOne(d => d.CursoUnidade)
                .WithMany(p => p.CursoUnidadePeriodos)
                .HasForeignKey(d => d.CursoUnidadeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblcursounidadeperiodo_tblcursounidade");

            builder.HasOne(d => d.Periodo)
                .WithMany(p => p.CursoUnidadePeriodos)
                .HasForeignKey(d => d.PeriodoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblcursounidadeperiodo_tblperiodo");

        }
    }
}
