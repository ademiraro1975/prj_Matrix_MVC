using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using matriz.Core.Domain.Entities.PontuacaoProfessor;

namespace matriz.Infra.Data.EntitiesConfigurarion.PontuacaoProfessor
{
    public class ParametroConfiguration : IEntityTypeConfiguration<Parametro>
    {

        public void Configure(EntityTypeBuilder<Parametro> builder)
        {
            builder.HasKey(e => e.IdParametro).HasName("PK_idparametro");

            builder.ToTable("parametro", "pontuacaop");

            builder.Property(e => e.IdParametro)
                .HasColumnName("idparametro");
            builder.Property(e => e.Descricao)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("descricao");
            builder.Property(e => e.IdTipoParametro)
                .HasColumnName("idtipoparametro");

            builder.HasOne(d => d.TipoParametro)
                .WithMany(p => p.Parametro)
                .HasForeignKey(d => d.IdTipoParametro)
                .HasConstraintName("FK_idtipoparametro");

        }
    }
}
