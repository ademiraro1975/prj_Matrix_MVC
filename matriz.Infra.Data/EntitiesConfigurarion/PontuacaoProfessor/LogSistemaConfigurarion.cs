using matriz.Core.Domain.Entities.PontuacaoProfessor;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace matriz.Infra.Data.EntitiesConfigurarion.PontuacaoProfessor
{
    public class LogSistemaConfiguration : IEntityTypeConfiguration<LogSistema>
    {
        public void Configure(EntityTypeBuilder<LogSistema> builder)
        {

            builder.HasKey(e => e.Id)
                .HasName("PK_tbllogsistemas");

            builder.ToTable("logsistemas", "acesso");

            builder.Property(e => e.Id)
                .HasColumnName("idlogsistemas");
            builder.Property(e => e.Datacadastro)
                .HasColumnType("datetime")
                .HasColumnName("datacadastro");
            builder.Property(e => e.Detalhe)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("detalhe");
            builder.Property(e => e.RegistroId)
                .HasColumnName("idregistro");
            builder.Property(e => e.RotinaOperacaoId)
                .HasColumnName("idrotinaoperacao");
            builder.Property(e => e.SistemaId)
                .HasColumnName("idsistema");
            builder.Property(e => e.UsuarioId)
                .HasColumnName("idusuario");
            builder.Property(e => e.MaquinaIP)
                .HasMaxLength(39)
                .IsUnicode(false)
                .HasColumnName("ipmaquina");
            builder.Property(e => e.Navegador)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("navegador");

            builder.HasOne(d => d.RotinaOperacao)
                .WithMany(p => p.LogSistemas)
                .HasForeignKey(d => d.RotinaOperacaoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_logsistemas_rotinaoperacao");

            builder.HasOne(d => d.Sistema)
                .WithMany(p => p.LogSistemas)
                .HasForeignKey(d => d.SistemaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_logsistemas_sistema");

        }
    }
}
