using matriz.Core.Domain.Entities.PontuacaoProfessor;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace matriz.Infra.Data.EntitiesConfigurarion.PontuacaoProfessor
{
    public class ModalidadeConfiguration : IEntityTypeConfiguration<Modalidade>
    {
        public void Configure(EntityTypeBuilder<Modalidade> builder)
        {

            builder.ToTable("tblmodalidade", "dbo");

            builder.Property(e => e.Id)
                .HasComment("*identificador*")
                .HasColumnName("id");
            builder.Property(e => e.Descricao)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("descricao");
            builder.Property(e => e.Modular)
                .HasColumnName("modular");
            builder.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome");
            builder.Property(e => e.Nomenclatura)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nomenclatura");

        }
    }
}