using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using matriz.Core.Domain.Entities.PontuacaoProfessor;

namespace matriz.Infra.Data.EntitiesConfigurarion.PontuacaoProfessor
{
    public class CursoUnidadeConfiguration : IEntityTypeConfiguration<CursoUnidade>
    {
        public void Configure(EntityTypeBuilder<CursoUnidade> builder)
        {

            builder.HasKey(e => e.Id).HasName("PK__tblcurso__3213E83F0C85DE4D");

            builder.ToTable("tblcursounidade", "dbo");

            builder.Property(e => e.Id)
                .HasColumnName("id");
            builder.Property(e => e.Estagio)
                .HasColumnName("estagio");
            builder.Property(e => e.CursoId)
                .HasColumnName("idcurso");
            builder.Property(e => e.UnidadeId)
                .HasColumnName("idunidade");
            builder.Property(e => e.Status)
                .HasColumnName("status");
            builder.Property(e => e.TCC)
                .HasColumnName("tcc");

            builder.HasOne(d => d.Curso).WithMany(p => p.CursoUnidades)
                .HasForeignKey(d => d.CursoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblcursounidade_tblcurso");

            builder.HasOne(d => d.Unidade).WithMany(p => p.CursoUnidades)
                .HasForeignKey(d => d.UnidadeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblcursounidade_tblunidade");

        }
    }
}
