using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using matriz.Core.Domain.Entities.PontuacaoProfessor;

namespace matriz.Infra.Data.EntitiesConfigurarion.PontuacaoProfessor.OK
{
    public class PontuacaoConfigurarion : IEntityTypeConfiguration<Pontuacao>
    {

        public void Configure(EntityTypeBuilder<Pontuacao> builder)
        {
            builder.HasKey(e => e.IdPontuacao).HasName("PK_idpontuacao");

            builder.ToTable("pontuacao", "pontuacaop");

            builder.Property(e => e.IdPontuacao)
                .HasColumnName("idpontuacao");
            builder.Property(e => e.DeducoesPont)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("deducoes_pont");
            builder.Property(e => e.IdProcessoAtribuicao)
                .HasColumnName("idprocessoatribuicao");
            builder.Property(e => e.IdProfessor)
                .HasColumnName("idprofessor");
            builder.Property(e => e.PontuacaoEscolaPont)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("pontuacao_escola_pont");
            builder.Property(e => e.PontuacaoFiebPont)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("pontuacao_fieb_pont");
            builder.Property(e => e.TituloPont)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("titulo_pont");

            builder.HasOne(d => d.Professor)
                .WithMany(p => p.Pontuacao)
                .HasForeignKey(d => d.IdProfessor)
                .HasConstraintName("FK_processoatribuicao");
            builder.HasOne(d => d.ProcessoAtribuicao)
                .WithMany(p => p.Pontuacao)
                .HasForeignKey(d => d.IdProcessoAtribuicao)
                .HasConstraintName("FK_processoatribuicao");

        }
    }
}
