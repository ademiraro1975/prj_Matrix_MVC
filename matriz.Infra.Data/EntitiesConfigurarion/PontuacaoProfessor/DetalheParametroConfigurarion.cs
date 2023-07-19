using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using matriz.Core.Domain.Entities.PontuacaoProfessor;

namespace matriz.Infra.Data.EntitiesConfigurarion.PontuacaoProfessor
{
    public class DetalheParametroConfigurarion : IEntityTypeConfiguration<DetalheParametro>
    {
        public void Configure(EntityTypeBuilder<DetalheParametro> builder)
        {
            builder.HasKey(e => e.IdDetalheParametro)
                .HasName("PK_iddetalheparametro");

            builder.ToTable("detalheparametro", "pontuacaop");

            builder.Property(e => e.IdDetalheParametro)
                .HasColumnName("iddetalheparametro");
            builder.Property(e => e.DataAlteracaoParam)
                .HasColumnType("date")
                .HasColumnName("dataalteracao");
            builder.Property(e => e.IdOperacaoParametro)
                .HasColumnName("idoperacaoparametro");
            builder.Property(e => e.IdParametro)
                .HasColumnName("idparametro");
            builder.Property(e => e.IdProcessoAtribuicao)
                .HasColumnName("idprocessoatribuicao");
            builder.Property(e => e.IdUnidadeParametro)
                .HasColumnName("idunidadeparametro");
            builder.Property(e => e.LimiteParam)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("limite");
            builder.Property(e => e.ValorParam)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("valor");

            builder.HasOne(d => d.OperacaoParametro).WithMany(p => p.DetalheParametro)
                .HasForeignKey(d => d.IdDetalheParametro)
                .HasConstraintName("FK_idoperacaoparametro");

            builder.HasOne(d => d.Parametro).WithMany(p => p.DetalheParametro)
                .HasForeignKey(d => d.IdParametro)
                .HasConstraintName("FK_idparametro");

            builder.HasOne(d => d.ProcessoAtribuicao).WithMany(p => p.DetalheParametro)
                .HasForeignKey(d => d.IdProcessoAtribuicao)
                .HasConstraintName("FK_idprocessoatribuicao");

            builder.HasOne(d => d.UnidadeParametro).WithMany(p => p.DetalheParametro)
                .HasForeignKey(d => d.IdUnidadeParametro)
                .HasConstraintName("FK_idunidadeparametro");
        }
    }
}

