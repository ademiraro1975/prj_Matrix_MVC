
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using matriz.Core.Domain.Entities.PontuacaoProfessor;

namespace matriz.Infra.Data.EntitiesConfigurarion.PontuacaoProfessor
{
    public class TipoAcessoConfiguration : IEntityTypeConfiguration<TipoAcesso>
    {
        public void Configure(EntityTypeBuilder<TipoAcesso> builder)
        {
            builder.HasKey(e => e.IdTipoAcesso);

            builder.ToTable("tipoacesso", "souFieb");

            builder.Property(e => e.IdTipoAcesso)
                .HasColumnName("idtipoacesso");
            builder.Property(e => e.DescricaoTipoAcesso)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descricao");

        }
    }
}
