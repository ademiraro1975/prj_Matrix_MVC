using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using matriz.Core.Domain.Entities.PontuacaoProfessor;

namespace matriz.Infra.Data.EntitiesConfigurarion.PontuacaoProfessor
{
    public class CursoConfiguration : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {

            builder.HasKey(e => e.Id).HasName("PK__tblcurso__3213E83F403A8C7D");

            builder.ToTable("tblcurso", "dbo");

            builder.Property(e => e.Id)
                .HasColumnName("id");
            builder.Property(e => e.Atribuicao)
                .IsUnicode(false)
                .HasColumnName("atribuicao");
            builder.Property(e => e.Codigo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("codigo");
            builder.Property(e => e.Fundlegal)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("fundlegal");
            builder.Property(e => e.HabilitacaoId)
                .HasColumnName("idhabilitacaofinal");
            builder.Property(e => e.ModalidadeId)
                .HasColumnName("idmodalidade");
            builder.Property(e => e.PeriodoId)
                .HasColumnName("idperiodo");
            builder.Property(e => e.Nome)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nome");
            builder.Property(e => e.Perfilprofissional)
                .IsUnicode(false)
                .HasColumnName("perfilprofissional");
            builder.Property(e => e.Quantidadeniveis)
                .HasDefaultValueSql("((3))")
                .HasColumnName("quantidadeniveis");

            builder.HasOne(d => d.HabilitacaoFinal).WithMany(p => p.Cursos)
                .HasForeignKey(d => d.HabilitacaoId)
                .HasConstraintName("FK_tblcurso_tblhabilitacao");

            builder.HasOne(d => d.Modalidade).WithMany(p => p.Cursos)
                .HasForeignKey(d => d.ModalidadeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblcurso_tblmodalidade");

        }
    }
}

