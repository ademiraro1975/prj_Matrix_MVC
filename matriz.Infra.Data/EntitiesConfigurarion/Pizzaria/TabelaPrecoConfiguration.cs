
using matriz.Core.Domain.Entities.Pizzaria;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz.Infra.Data.EntitiesConfigurarion.Pizzaria
{
    public class TabelaPrecoConfiguration : IEntityTypeConfiguration<TabelaPreco>
    {
        public void Configure(EntityTypeBuilder<TabelaPreco> builder)
        {

            builder.HasKey(e => e.TabelaPrecoId).HasName("PK__tabelaPr__17176E24FB986834");

            builder.ToTable("tabelaPreco", "pizzaria");

            builder.Property(e => e.TabelaPrecoId).HasColumnName("tabelaPrecoId");
            builder.Property(e => e.Preco)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("preco");

        }
    }
}
