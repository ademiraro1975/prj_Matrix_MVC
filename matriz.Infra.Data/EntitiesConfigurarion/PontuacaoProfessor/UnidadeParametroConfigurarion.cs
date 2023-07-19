using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using matriz.Core.Domain.Entities.PontuacaoProfessor;

namespace matriz.Infra.Data.EntitiesConfigurarion.PontuacaoProfessor.OK
{
    public class UnidadeParametroConfigurarion : IEntityTypeConfiguration<UnidadeParametro>
    {

        public void Configure(EntityTypeBuilder<UnidadeParametro> builder)
        {
            builder.HasKey(e => e.IdUnidadeParametro).HasName("PK_idunidadeparametro");

            builder.ToTable("unidadeparametro", "pontuacaop");

            builder.Property(e => e.IdUnidadeParametro).HasColumnName("idunidadeparametro");
            builder.Property(e => e.Descricao)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descricao");

        }
    }
}
