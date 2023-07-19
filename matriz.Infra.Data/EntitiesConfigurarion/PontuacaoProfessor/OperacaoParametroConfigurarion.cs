using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using matriz.Core.Domain.Entities.PontuacaoProfessor;

namespace matriz.Infra.Data.EntitiesConfigurarion.PontuacaoProfessor.OK
{
    public class OperacaoParametroConfigurarion : IEntityTypeConfiguration<OperacaoParametro>
    {
        public void Configure(EntityTypeBuilder<OperacaoParametro> builder)
        {
            builder.HasKey(e => e.IdOperacaoParametro).HasName("PK_idoperacaoparametro");

            builder.ToTable("operacaoparametro", "pontuacaop");

            builder.Property(e => e.IdOperacaoParametro).HasColumnName("idoperacaoparametro");
            builder.Property(e => e.DetalheParametro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("detalheparametro");
        }
    }
}

