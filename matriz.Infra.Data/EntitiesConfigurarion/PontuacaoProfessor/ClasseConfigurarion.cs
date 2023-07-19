using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public class ClasseConfiguration : IEntityTypeConfiguration<Classe>
    {
        public void Configure(EntityTypeBuilder<Classe> builder)
        {

            builder.ToTable("tblclasse", "dbo");

            builder.Property(e => e.Id)
                .HasColumnName("id");
            builder.Property(e => e.Ano)
                .HasComment("*ano*")
                .HasColumnName("ano");
            builder.Property(e => e.Ciclo)
                .HasColumnName("ciclo");
            builder.Property(e => e.ClasseNome)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("classe");
            builder.Property(e => e.CursoUnidadeId)
                .HasColumnName("idcursounidade");
            builder.Property(e => e.PeriodoId)
                .HasColumnName("idperiodo");
            builder.Property(e => e.Nivel)
                .HasColumnName("nivel");
            builder.Property(e => e.NumeroAlunos)
                .HasColumnName("numeroalunos");
            builder.Property(e => e.Turma)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("turma");


            builder.HasOne(d => d.CursoUnidade).WithMany(p => p.Classes)
                .HasForeignKey(d => d.CursoUnidadeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblclasse_tblcursounidade");

            builder.HasOne(d => d.Periodo).WithMany(p => p.Classes)
                .HasForeignKey(d => d.PeriodoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblclasse_tblperiodo");

        }
    }
}
