using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public class CargoDepartamentoUnidadeConfiguration : IEntityTypeConfiguration<CargoDepartamentoUnidade>
    {
        public void Configure(EntityTypeBuilder<CargoDepartamentoUnidade> builder)
        {

            builder.ToTable("tblcargodepartamentounidade", "dbo");

            builder.Property(e => e.Id)
                .HasColumnName("id");
            builder.Property(e => e.CargoID)
                .HasColumnName("idcargo");
            builder.Property(e => e.DepartamentoUnidadeId)
                .HasColumnName("iddepartamentounidade");

            builder.HasOne(d => d.Cargo).WithMany(p => p.CargoDepartamentoUnidades)
                .HasForeignKey(d => d.CargoID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblcargodepartamentounidade_tblcargo");

            builder.HasOne(d => d.DepartamentoUnidade).WithMany(p => p.CargoDepartamentoUnidades)
                .HasForeignKey(d => d.DepartamentoUnidadeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblcargodepartamentounidade_tbldepartamentounidade");

        }
    }
}
