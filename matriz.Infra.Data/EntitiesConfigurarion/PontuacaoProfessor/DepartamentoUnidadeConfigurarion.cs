using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using matriz.Core.Domain.Entities.PontuacaoProfessor;

namespace matriz.Infra.Data.EntitiesConfigurarion.PontuacaoProfessor
{
    public class DepartamentoUnidadeConfiguration : IEntityTypeConfiguration<DepartamentoUnidade>
    {
        public void Configure(EntityTypeBuilder<DepartamentoUnidade> builder)
        {

            builder.ToTable("tbldepartamentounidade", "dbo");

            builder.Property(e => e.Id)
                .HasColumnName("id");
            builder.Property(e => e.DepartamentoId)
                .HasColumnName("iddepartamento");
            builder.Property(e => e.UnidadeId)
                .HasColumnName("idunidade");

            builder.HasOne(d => d.Departamento)
                .WithMany(p => p.DepartamentoUnidades)
                .HasForeignKey(d => d.DepartamentoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbldepartamentounidade_tbldepartamento");

            builder.HasOne(d => d.Unidade)
                .WithMany(p => p.DepartamentoUnidades)
                .HasForeignKey(d => d.UnidadeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbldepartamentounidade_tblunidade");

        }
    }
}
