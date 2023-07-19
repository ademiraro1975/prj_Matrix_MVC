using matriz.Core.Domain.Entities.PontuacaoProfessor;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace matriz.Infra.Data.EntitiesConfigurarion.PontuacaoProfessor
{
    public class UsuarioPermissaoConfiguration : IEntityTypeConfiguration<UsuarioPermissao>
    {
        public void Configure(EntityTypeBuilder<UsuarioPermissao> builder)
        {

            builder.HasKey(e => e.Id);

            builder.ToTable("usuariopermissao", "acesso");

            builder.Property(e => e.Id)
                .HasColumnName("idusuariopermissao");
            builder.Property(e => e.RotinaOperacaoId)
                .HasColumnName("idrotinaoperacao");
            builder.Property(e => e.UnidadeId)
                .HasColumnName("idunidade");
            builder.Property(e => e.UsuarioId)
                .HasColumnName("idusuario");

            builder.HasOne(d => d.RotinaOperacao)
                .WithMany(p => p.UsuarioPermissaos)
                .HasForeignKey(d => d.RotinaOperacaoId)
                .HasConstraintName("FK_usuariopermissao_rotinaoperacao");

            builder.HasOne(d => d.Unidade)
                .WithMany(p => p.UsuarioPermissaos)
                .HasForeignKey(d => d.UnidadeId)
                .HasConstraintName("FK_usuariopermissao_unidade");

            builder.HasOne(d => d.Usuario)
                .WithMany(p => p.UsuarioPermissaos)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_usuariopermissao_usuario");

        }
    }
}