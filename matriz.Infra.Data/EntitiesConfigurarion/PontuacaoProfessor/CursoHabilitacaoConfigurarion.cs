using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public class CursoHabilitacaoConfiguration : IEntityTypeConfiguration<CursoHabilitacao>
    {
        public void Configure(EntityTypeBuilder<CursoHabilitacao> builder)
        {

            builder.HasKey(e => e.Id).HasName("PK__tblcurso__3213E83F10566F31");

            builder.ToTable("tblcursohabilitacao", "dbo");

            builder.Property(e => e.Id)
                .HasColumnName("id");
            builder.Property(e => e.CursoId)
                .HasColumnName("idcurso");
            builder.Property(e => e.HabilitacaoId)
                .HasColumnName("idhabilitacao");
            builder.Property(e => e.Ordem)
                .HasColumnName("ordem");

            builder.HasOne(d => d.Curso)
                .WithMany(p => p.CursoHabilitacaos)
                .HasForeignKey(d => d.CursoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblcursohabilitacao_tblcurso");

            builder.HasOne(d => d.Habilitacao)
                .WithMany(p => p.CursoHabilitacaos)
                .HasForeignKey(d => d.HabilitacaoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblcursohabilitacao_tblhabilitacao");

        }
    }
}
