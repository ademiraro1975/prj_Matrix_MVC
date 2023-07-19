using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using matriz.Core.Domain.Entities.PontuacaoProfessor;

namespace matriz.Infra.Data.EntitiesConfigurarion.PontuacaoProfessor
{
    public class TipoParametroConfiguration : IEntityTypeConfiguration<TipoParametro>
    {
        public void Configure(EntityTypeBuilder<TipoParametro> builder)
        {
            builder.HasKey(e => e.IdTipoParametro).HasName("PK_id_tipo_param");

            builder.ToTable("tipoparametro", "pontuacaop");

            builder.Property(e => e.IdTipoParametro).HasColumnName("idtipoparametro");
            builder.Property(e => e.Abreviacao)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("abreviacao");
            builder.Property(e => e.DescricaoTipoAcesso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descricao");

        }
    }
}
