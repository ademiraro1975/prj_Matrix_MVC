using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using matriz.Core.Domain.Entities.PontuacaoProfessor;

namespace matriz.Infra.Data.EntitiesConfigurarion.PontuacaoProfessor.OK
{
    public class ProcessoAtribuicaoConfigurarion : IEntityTypeConfiguration<ProcessoAtribuicao>
    {

        public void Configure(EntityTypeBuilder<ProcessoAtribuicao> builder)
        {
            builder.HasKey(e => e.IdProcessoAtribuicao).HasName("PK_idprocessoatribuicao");

            builder.ToTable("processoatribuicao", "pontuacaop");

            builder.Property(e => e.IdProcessoAtribuicao).HasColumnName("idprocessoatribuicao");
            builder.Property(e => e.Ativo)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ativo");
            builder.Property(e => e.DataFim)
                .HasColumnType("date")
                .HasColumnName("datafim");
            builder.Property(e => e.DataInicio)
                .HasColumnType("date")
                .HasColumnName("datainicio");
            builder.Property(e => e.Descricao)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("descricao");
            builder.Property(e => e.Observacoes)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("observacoes");
            builder.Property(e => e.Portaria)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("portaria");

        }
    }
}
