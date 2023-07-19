using System;
using System.Collections.Generic;
using matriz.Core.Domain.Entities.PontuacaoProfessor;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace matriz.Infra.Data.EntitiesConfigurarion.PontuacaoProfessor
{
    public class RotinaOperacaoConfiguration : IEntityTypeConfiguration<RotinaOperacao>
    {
        public void Configure(EntityTypeBuilder<RotinaOperacao> builder)
        {

            builder.HasKey(e => e.Id);

            builder.ToTable("rotinaoperacao", "acesso");

            builder.Property(e => e.Id)
                .HasColumnName("idrotinaoperacao");
            builder.Property(e => e.OperacaoId)
                .HasColumnName("idoperacao");
            builder.Property(e => e.RotinaId)
                .HasColumnName("idrotina");
            builder.Property(e => e.RotinaOperacaoPaiId)
                .HasColumnName("idrotinaoperacaopai");
            builder.Property(e => e.Novaaba)
                .HasColumnName("novaaba");

            builder.HasOne(d => d.Operacao)
                .WithMany(p => p.RotinaOperacaos)
                .HasForeignKey(d => d.OperacaoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_rotinaoperacao_operacao");

            builder.HasOne(d => d.Rotina)
                .WithMany(p => p.RotinaOperacaos)
                .HasForeignKey(d => d.RotinaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_rotinaoperacao_rotina");

        }
    }
}