
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
    public class PizzaDetalheConfiguration : IEntityTypeConfiguration<PizzaDetalhe>
    {
        public void Configure(EntityTypeBuilder<PizzaDetalhe> builder)
        {

            builder.HasKey(e => e.PizzaDetalheId).HasName("PK__pizzaDet__2E6A3E3BAC173904");

            builder.ToTable("pizzaDetalhe", "pizzaria");

            builder.Property(e => e.PizzaDetalheId).HasColumnName("pizzaDetalheId");
            builder.Property(e => e.PizzaId).HasColumnName("pizzaId");
            builder.Property(e => e.TabelaPrecoId).HasColumnName("tabelaPrecoId");
            builder.Property(e => e.TamanhoId).HasColumnName("tamanhoId");
            builder.Property(e => e.TipoId).HasColumnName("tipoId");

            builder.HasOne(d => d.Pizza).WithMany(p => p.PizzaDetalhes)
                .HasForeignKey(d => d.PizzaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__pizzaDeta__pizza__3E52440B");

            builder.HasOne(d => d.TabelaPreco).WithMany(p => p.PizzaDetalhes)
                .HasForeignKey(d => d.TabelaPrecoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__pizzaDeta__tabel__3F466844");

            builder.HasOne(d => d.Tamanho).WithMany(p => p.PizzaDetalhes)
                .HasForeignKey(d => d.TamanhoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__pizzaDeta__taman__403A8C7D");

            builder.HasOne(d => d.Tipo).WithMany(p => p.PizzaDetalhes)
                .HasForeignKey(d => d.TipoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__pizzaDeta__tipoI__412EB0B6");

        }
    }
}
