using matriz.Core.Domain.Entities.PontuacaoProfessor;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace matriz.Infra.Data.EntitiesConfigurarion.PontuacaoProfessor
{
    public class UnidadeConfiguration : IEntityTypeConfiguration<Unidade>
    {
        public void Configure(EntityTypeBuilder<Unidade> builder)
        {

            builder.HasKey(e => e.Id).HasName("PK__tblunida__3213E83F6477ECF3");

            builder.ToTable("tblunidade", "dbo");

            builder.Property(e => e.Id)
                .HasColumnName("id");

            builder.Property(e => e.CNPJ)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("cnpj");

            builder.Property(e => e.Codigo)
                .HasColumnName("codigo");

            builder.Property(e => e.Decreto)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("decreto");

            builder.Property(e => e.Email)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("email");

            builder.Property(e => e.EmailSecretariaUnidadeEscolar)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("email_sue");

            builder.Property(e => e.CEPId)
                .HasColumnName("idcep");

            builder.Property(e => e.EntidadeId).HasColumnName("identidade");

            builder.Property(e => e.Nome)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nome");

            builder.Property(e => e.NomeAbreviado)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nomeabreviado");

            builder.Property(e => e.NomeCompleto)
                .IsUnicode(false)
                .HasColumnName("nomecompleto");

            builder.Property(e => e.EnderecoNumero)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("numero");

            builder.Property(e => e.Telefone)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("telefone");


        }
    }
}