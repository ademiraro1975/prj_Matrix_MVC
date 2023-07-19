using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using matriz.Core.Domain.Entities.PontuacaoProfessor;

namespace matriz.Infra.Data.EntitiesConfigurarion.PontuacaoProfessor
{
    public class DetalhePontuacaoConfigurarion : IEntityTypeConfiguration<DetalhePontuacao>
    {
        public void Configure(EntityTypeBuilder<DetalhePontuacao> builder)
        {
            builder.HasKey(e => e.IdDetalhePontuacao).HasName("PK_iddetalhepontuacao");

            builder.ToTable("detalhepontuacao", "pontuacaop");

            builder.Property(e => e.IdDetalhePontuacao)
                .HasColumnName("iddetalhepontuacao");
            builder.Property(e => e.DataConclusao)
                .HasColumnType("date")
                .HasColumnName("data_conclusao");
            builder.Property(e => e.IdDetalheParametro)
                .HasColumnName("iddetalheparametro");
            builder.Property(e => e.IdPontuacao)
                .HasColumnName("idpontuacao");
            builder.Property(e => e.QuantidadeDias)
                .HasColumnName("quantidade_dias");
            builder.Property(e => e.QuantidadeDiasAnt)
                .HasColumnName("quantidade_dias_ant");
            builder.Property(e => e.QuantidadePont)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("quantidade_pont");
            builder.Property(e => e.QuantidadePontAnt)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("quantidade_pont_ant");
            builder.Property(e => e.TipoPontuacao)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipopontuacao");

            builder.HasOne(d => d.DetalheParametro)
                .WithMany(p => p.DetalhePontuacao)
                .HasForeignKey(d => d.IdDetalheParametro)
                .HasConstraintName("FK_iddetalheparametro");
            builder.HasOne(d => d.Pontuacao)
                .WithMany(p => p.DetalhePontuacao)
                .HasForeignKey(d => d.IdPontuacao)
                .HasConstraintName("FK_idpontuacao");
        }
    }
}

