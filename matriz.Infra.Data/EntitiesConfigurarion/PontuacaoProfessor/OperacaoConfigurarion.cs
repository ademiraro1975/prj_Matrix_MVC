using matriz.Core.Domain.Entities.PontuacaoProfessor;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace matriz.Infra.Data.EntitiesConfigurarion.PontuacaoProfessor
{
    public class OperacaoConfiguration : IEntityTypeConfiguration<Operacao>
    {
        public void Configure(EntityTypeBuilder<Operacao> builder)
        {

            builder.HasKey(e => e.Id);

            builder.ToTable("operacao", "acesso");

            builder.Property(e => e.Id)
                .HasColumnName("idoperacao");
            builder.Property(e => e.Descricao)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descricao");
            builder.Property(e => e.Nomenclatura)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nomenclatura");

        }
    }
}