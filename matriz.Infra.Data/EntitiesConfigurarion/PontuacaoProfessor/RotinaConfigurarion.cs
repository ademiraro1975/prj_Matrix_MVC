using matriz.Core.Domain.Entities.PontuacaoProfessor;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace matriz.Infra.Data.EntitiesConfigurarion.PontuacaoProfessor
{
    public class RotinaConfiguration : IEntityTypeConfiguration<Rotina>
    {
        public void Configure(EntityTypeBuilder<Rotina> builder)
        {

            builder.HasKey(e => e.Id);

            builder.ToTable("rotina", "acesso");

            builder.Property(e => e.Id)
                .HasColumnName("idrotina");
            builder.Property(e => e.Descricao)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descricao");
            builder.Property(e => e.SistemaId)
                .HasColumnName("idsistema");
            builder.Property(e => e.Menuordem)
                .HasColumnName("menuordem");
            builder.Property(e => e.Nomenclatura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nomenclatura");
            builder.Property(e => e.Prioridade)
                .HasColumnName("prioridade");

            builder.HasOne(d => d.Sistema)
                .WithMany(p => p.Rotinas)
                .HasForeignKey(d => d.SistemaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_rotina_sistema");

        }
    }
}