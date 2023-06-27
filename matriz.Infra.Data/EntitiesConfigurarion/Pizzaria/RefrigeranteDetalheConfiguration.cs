
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
    public class RefrigeranteDetalheConfiguration : IEntityTypeConfiguration<RefrigeranteDetalhe>
    {
        public void Configure(EntityTypeBuilder<RefrigeranteDetalhe> builder)
        {

            builder.HasKey(e => e.RefrigeranteDetalheId).HasName("PK__refriger__498C26D1DDF696C5");

            builder.ToTable("refrigeranteDetalhe", "pizzaria");

            builder.Property(e => e.RefrigeranteDetalheId).HasColumnName("refrigeranteDetalheId");
            builder.Property(e => e.RefrigeranteId).HasColumnName("refrigeranteId");
            builder.Property(e => e.TabelaPrecoId).HasColumnName("tabelaPrecoId");
            builder.Property(e => e.TamanhoId).HasColumnName("tamanhoId");
            builder.Property(e => e.TipoId).HasColumnName("tipoId");

            builder.HasOne(d => d.Refrigerante).WithMany(p => p.RefrigeranteDetalhes)
                .HasForeignKey(d => d.RefrigeranteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__refrigera__refri__4E88ABD4");

            builder.HasOne(d => d.TabelaPreco).WithMany(p => p.RefrigeranteDetalhes)
                .HasForeignKey(d => d.TabelaPrecoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__refrigera__tabel__4F7CD00D");

            builder.HasOne(d => d.Tamanho).WithMany(p => p.RefrigeranteDetalhes)
                .HasForeignKey(d => d.TamanhoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__refrigera__taman__5070F446");

            builder.HasOne(d => d.Tipo).WithMany(p => p.RefrigeranteDetalhes)
                .HasForeignKey(d => d.TipoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__refrigera__tipoI__5165187F");

        }
    }
}
