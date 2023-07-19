using matriz.Core.Domain.Entities.PontuacaoProfessor;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace matriz.Infra.Data.EntitiesConfigurarion.PontuacaoProfessor
{
    public class FuncionarioCargoDepartamentoUnidadeConfiguration : IEntityTypeConfiguration<FuncionarioCargoDepartamentoUnidade>
    {
        public void Configure(EntityTypeBuilder<FuncionarioCargoDepartamentoUnidade> builder)
        {

            builder.ToTable("tblfuncionariocargodepartamentounidade", "dbo");

            builder.Property(e => e.Id)
                .HasColumnName("id");
            builder.Property(e => e.Ativo)
                .HasColumnName("ativo");
            builder.Property(e => e.Emaildocente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("emaildocente");
            builder.Property(e => e.AtribuicaoId)
                .HasColumnName("idatribuicao");
            builder.Property(e => e.CargoDepartamentoUnidadeId)
                .HasColumnName("idcargodepartamentounidade");
            builder.Property(e => e.FuncionarioId)
                .HasColumnName("idfuncionario");
            builder.Property(e => e.Matricula)
                .HasColumnName("matricula");
            builder.Property(e => e.SegundoCargo)
                .HasColumnName("segundo_cargo");

            builder.HasOne(d => d.Atribuicao)
                .WithMany(p => p.FuncionarioCargoDepartamentoUnidades)
                .HasForeignKey(d => d.AtribuicaoId)
                .HasConstraintName("FK_tblfuncionariocargodepartamentounidade_tblatribuicao");

            builder.HasOne(d => d.CargoDepartamentoUnidade)
                .WithMany(p => p.FuncionarioCargoDepartamentoUnidades)
                .HasForeignKey(d => d.CargoDepartamentoUnidadeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblfuncionariocargodepartamentounidade_tblcargodepartamentounidade");

            builder.HasOne(d => d.Funcionario)
                .WithMany(p => p.FuncionarioCargoDepartamentoUnidades)
                .HasForeignKey(d => d.FuncionarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblfuncionariocargodepartamentounidade_tblfuncionario");

        }
    }
}
