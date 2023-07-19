using matriz.Core.Domain.Entities.PontuacaoProfessor;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace matriz.Infra.Data.EntitiesConfigurarion.PontuacaoProfessor
{
    public class CursoAreaConfiguration : IEntityTypeConfiguration<CursoArea>
    {

        public void Configure(EntityTypeBuilder<CursoArea> builder)
        {

            builder.ToTable("tblcursoarea", "dbo");

            builder.Property(e => e.Id)
                .HasColumnName("id");
            builder.Property(e => e.AnoFim)
                .HasColumnName("anofim");
            builder.Property(e => e.AnoInicio)
                .HasColumnName("anoinicio");
            builder.Property(e => e.CicloFim)
                .HasColumnName("ciclofim");
            builder.Property(e => e.CicloInicio)
                .HasColumnName("cicloinicio");
            builder.Property(e => e.AreaId)
                .HasColumnName("idarea");
            builder.Property(e => e.CursoId)
                .HasColumnName("idcurso");

            builder.HasOne(d => d.AreaConhecimento)
                .WithMany(p => p.CursoAreas)
                .HasForeignKey(d => d.AreaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblcursoarea_tblareaconhecimento");

            builder.HasOne(d => d.Curso)
                .WithMany(p => p.CursoAreas)
                .HasForeignKey(d => d.CursoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblcursoarea_tblcurso");


        }
    }
}
