using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public class CursoUnidadeFundLegalConfiguration : IEntityTypeConfiguration<CursoUnidadeFundLegal>
    {
        public void Configure(EntityTypeBuilder<CursoUnidadeFundLegal> builder)
        {

            builder.HasKey(e => e.Id).HasName("PK__tblcurso__3213E83FE13ED9C6");

            builder.ToTable("tblcursounidadefundlegal", "dbo");

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
            builder.Property(e => e.DataParecer)
                .HasColumnType("datetime")
                .HasColumnName("dataparecer");
            builder.Property(e => e.CursoUnidadeId)
                .HasColumnName("idcursounidade");
            builder.Property(e => e.FundLegalId)
                .HasColumnName("idfundlegal");

            builder.HasOne(d => d.CursoUnidades).WithMany(p => p.CursoUnidadeFundLegals)
                .HasForeignKey(d => d.CursoUnidadeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblcursou__idcur__53D83C2D");

            builder.HasOne(d => d.FundLegals)
                .WithMany(p => p.CursoUnidadeFundLegals)
                .HasForeignKey(d => d.FundLegalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblcursou__idfun__52E417F4");

        }
    }
}
